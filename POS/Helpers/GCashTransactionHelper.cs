﻿using POS.Classes;
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
                    SELECT COALESCE(SUM(Amount), 0) AS GCashAvailableBalance
                    FROM (
	                    -- Cash In amount
	                    SELECT
		                    -SUM(Amt) AS Amount
	                    FROM [dbo].[GCashTransactions]
	                    WHERE ShiftID = @ShiftID
		                    AND TransactionType = 1

	                    UNION

	                    -- Cash Out amount
	                    SELECT
		                    SUM(Amt) AS Amount
	                    FROM [dbo].[GCashTransactions]
	                    WHERE ShiftID = @ShiftID
		                    AND TransactionType = 2

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
    }
}
