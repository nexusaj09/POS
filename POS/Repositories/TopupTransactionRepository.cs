using POS.Classes;
using POS.Helpers;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace POS.Repositories
{
    public class TopupTransactionRepository : DatabaseConnection
    {
        public async Task<bool> IsReferenceNumberExistsAsync(string referenceNumber)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                var sql = @"
                    SELECT TOP 1 1 AS IsReferenceNumberExists
                    FROM TopupTransactions
                    WHERE ReferenceNumber = @ReferenceNumber
                ";

                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ReferenceNumber", referenceNumber);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            if (!reader.HasRows)
                                return false;

                            var isReferenceNumberExists = Convert.ToBoolean(reader["IsReferenceNumberExists"].ToString());
                            return isReferenceNumberExists;
                        }

                        return false;
                    }
                }
            }
        }

        public async Task<bool> SaveTopupTransactionAsync(TopupTransaction topupTransaction)
        {
            using (var conn = new SqlConnection(GetConnectionString))
            {
                var sql = @"
                    INSERT INTO [dbo].[TopupTransactions] (
                        ReferenceNumber, Amount, TopupType, ShiftID,
                        CreatedByID, CreatedDateTime
                    ) VALUES (
                        @ReferenceNumber, @Amount, @TopupType, @ShiftID,
                        @CreatedByID, @CreatedDateTime
                    )
                ";

                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ReferenceNumber", topupTransaction.ReferenceNumber);
                    cmd.Parameters.AddWithValue("Amount", topupTransaction.Amount);
                    cmd.Parameters.AddWithValue("TopupType", topupTransaction.TopupType);
                    cmd.Parameters.AddWithValue("ShiftID", topupTransaction.ShiftID);
                    cmd.Parameters.AddWithValue("CreatedByID", topupTransaction.CreatedByID);
                    cmd.Parameters.AddWithValue("CreatedDateTime", topupTransaction.CreatedDateTime);

                    var result = await cmd.ExecuteNonQueryAsync();
                    return result > 0;
                }
            }
        }
    }
}
