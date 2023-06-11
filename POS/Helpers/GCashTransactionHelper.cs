using POS.Classes;
using POS.Entities;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace POS.Helpers
{
    public class GCashTransactionHelper : DatabaseConnection
    {
        public async Task<decimal> GetGCashAvailableBalanceAsync(int employeeShiftID)
        {
            using (var conn = new SqlConnection(GetConnectionString))
            {
                const string sql = @"
                    SET NOCOUNT ON;

                    IF OBJECT_ID('tempdb..#CashOut') IS NOT NULL
                    BEGIN
                        DROP TABLE #CashOut
                    END

                    CREATE TABLE #CashOut (
                        CashOutAmount DECIMAL(18, 4)
                    )

                    INSERT INTO #CashOut
                    SELECT
                        CASE
                            WHEN IsAmountIncludesFee = 1 THEN Amount
                            WHEN IsFeeDeductedOnCashOutAmount = 1 THEN (Amount - Fee)
                            ELSE Amount
                        END AS Amount
                    FROM [dbo].[GCashCashOuts]
                    WHERE ShiftID = @ShiftID

                    SELECT COALESCE(SUM(Amount), 0) AS GCashAvailableBalance
                    FROM (
                        -- Cash In amount
                        SELECT
                            -SUM(Amt) AS Amount
                        FROM [dbo].[GCashTransactions]
                        WHERE ShiftID = @ShiftID
                            AND TransactionType = 1

                        UNION

                        -- START: Cash Out amount
                        SELECT SUM(CashOutAmount) AS Amount FROM #CashOut
                        -- END: Cash Out amount

                        UNION

                        /*
                            Topup GCash account
                            this topup only used if there are insufficient funds
                            for GCASH Cash In transaction
                        */
                        SELECT
                            SUM(Amount) AS Amount
                        FROM TopupTransactions
                        WHERE ShiftID = @ShiftID
                            AND TopupType = 1
                    ) AS GCash

                    DROP TABLE #CashOut
                ";

                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ShiftID", employeeShiftID);
                    
                    var availableBalance = Convert.ToDecimal(await cmd.ExecuteScalarAsync());
                    return availableBalance;
                }
            }
        }

        public async Task<string> GetNextTransactionNbrAsync()
        {
            string dateStr = DateTime.Now.ToString("yyyyMMdd");

            using (var conn = new SqlConnection(GetConnectionString))
            {
                const string sql = @"
                    SELECT TOP 1 *
                    FROM [dbo].[GCashTransactions]
                    WHERE TransactionNbr LIKE @DateStr + '%'
                    ORDER BY TransactionNbr DESC
                ";

                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("DateStr", dateStr);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            if (!reader.HasRows)
                                return $"{dateStr}1001";

                            var currentRefNbr = reader["TransactionNbr"].ToString();
                            var count = int.Parse(currentRefNbr.Substring(8, 4));
                            return $"{dateStr}{(count + 1)}";
                        }

                        return $"{dateStr}1001";
                    }
                }
            }
        }

        public async Task<bool> SaveGCashTransactionAsync(GCashTransaction gcashTransaction)
        {
            using (var conn = new SqlConnection(GetConnectionString))
            {
                var sql = @"
                    INSERT INTO [dbo].[GCashTransactions] (
                        TransactionNbr, Amt, TransactionFee, RefNbr, TotalAmt,
                        ChangeAmt, TenderedAmt, ShiftID, TransactionType, IsNegative,
                        CreatedByID, CreatedDateTime
                    ) VALUES (
                        @TransactionNbr, @Amt, @TransactionFee, @RefNbr, @TotalAmt,
                        @ChangeAmt, @TenderedAmt, @ShiftID, @TransactionType, @IsNegative,
                        @CreatedByID, @CreatedDateTime
                    )
                ";

                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("TransactionNbr", gcashTransaction.TransactionNbr);
                    cmd.Parameters.AddWithValue("Amt", gcashTransaction.Amt);
                    cmd.Parameters.AddWithValue("TransactionFee", gcashTransaction.TransactionFee);
                    cmd.Parameters.AddWithValue("RefNbr", gcashTransaction.RefNbr);
                    cmd.Parameters.AddWithValue("TotalAmt", gcashTransaction.TotalAmt);
                    cmd.Parameters.AddWithValue("ChangeAmt", gcashTransaction.ChangeAmt);
                    cmd.Parameters.AddWithValue("TenderedAmt", gcashTransaction.TenderedAmt);
                    cmd.Parameters.AddWithValue("ShiftID", gcashTransaction.ShiftID);
                    cmd.Parameters.AddWithValue("TransactionType", gcashTransaction.TransactionType);
                    cmd.Parameters.AddWithValue("IsNegative", gcashTransaction.IsNegative);
                    cmd.Parameters.AddWithValue("CreatedByID", gcashTransaction.CreatedByID);
                    cmd.Parameters.AddWithValue("CreatedDateTime", gcashTransaction.CreatedDateTime);

                    var result = await cmd.ExecuteNonQueryAsync();
                    return result > 0;
                }
            }
        }

        public async Task<bool> SaveCashOutAsync(GCashCashOut cashOut)
        {
            using (var conn = new SqlConnection(GetConnectionString))
            {
                var sql = @"
                    INSERT INTO [dbo].[GCashCashOuts] (
                        ReferenceNumber, Amount, Fee, IsFeePaySeparately,
                        IsAmountIncludesFee, IsFeeDeductedOnCashOutAmount,
                        ShiftID, CreatedByID, CreatedDateTime
                    ) VALUES (
                        @ReferenceNumber, @Amount, @Fee, @IsFeePaySeparately,
                        @IsAmountIncludesFee, @IsFeeDeductedOnCashOutAmount,
                        @ShiftID, @CreatedByID, @CreatedDateTime
                    )
                ";

                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ReferenceNumber", cashOut.ReferenceNumber);
                    cmd.Parameters.AddWithValue("Amount", cashOut.Amount);
                    cmd.Parameters.AddWithValue("Fee", cashOut.Fee);
                    cmd.Parameters.AddWithValue("IsFeePaySeparately", cashOut.IsFeePaySeparately);
                    cmd.Parameters.AddWithValue("IsAmountIncludesFee", cashOut.IsAmountIncludesFee);
                    cmd.Parameters.AddWithValue("IsFeeDeductedOnCashOutAmount", cashOut.IsFeeDeductedOnCashOutAmount);
                    cmd.Parameters.AddWithValue("ShiftID", cashOut.ShiftID);
                    cmd.Parameters.AddWithValue("CreatedByID", cashOut.CreatedByID);
                    cmd.Parameters.AddWithValue("CreatedDateTime", cashOut.CreatedDateTime);

                    var result = await cmd.ExecuteNonQueryAsync();
                    return result > 0;
                }
            }
        }
    }
}
