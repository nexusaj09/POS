using POS.Classes;
using POS.Helpers;
using POS.Models;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace POS.Repositories
{
    public class ProductDiscountRepository : DatabaseConnection
    {
        public async Task<bool> SaveProductDiscountAsync(ProductDiscount productDiscount)
        {
            using (var conn = new SqlConnection(GetConnectionString))
            {
                const string sql = @"
                    INSERT INTO [dbo].[ProductDiscounts] (
	                    ProductCode, DiscountID, CreatedByID
                    ) VALUES (
	                    @ProductCode, @DiscountID, @CreatedByID
                    )
                ";

                conn.Open();
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("ProductCode", productDiscount.ProductCode);
                    cmd.Parameters.AddWithValue("DiscountID", productDiscount.DiscountID);
                    cmd.Parameters.AddWithValue("CreatedByID", productDiscount.CreatedByID);

                    var result = await cmd.ExecuteNonQueryAsync();
                    return result > 0;
                }
            }
        }
    }
}
