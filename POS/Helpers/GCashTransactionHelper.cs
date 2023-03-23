using POS.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace POS.Helpers
{
    public class GCashTransactionHelper : DatabaseConnection
    {
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
	                    ChangeAmt, TenderedAmt, ShiftID, TransactionType,
	                    CreatedByID, CreatedDateTime
                    ) VALUES (
	                    @TransactionNbr, @Amt, @TransactionFee, @RefNbr, @TotalAmt,
	                    @ChangeAmt, @TenderedAmt, @ShiftID, @TransactionType,
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
                    cmd.Parameters.AddWithValue("CreatedByID", gcashTransaction.CreatedByID);
                    cmd.Parameters.AddWithValue("CreatedDateTime", gcashTransaction.CreatedDateTime);

                    var result = await cmd.ExecuteNonQueryAsync();
                    return result > 0;
                }
            }
        }
    }
}
