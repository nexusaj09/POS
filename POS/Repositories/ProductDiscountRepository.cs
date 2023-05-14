using POS.Classes;
using POS.Helpers;
using POS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace POS.Repositories
{
    public class ProductDiscountRepository : DatabaseConnection
    {
        public async Task<bool> SaveProductDiscountAsync(ProductDiscount productDiscount)
        {
            try
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
            catch (Exception)
            {
                throw;
            }
        }

        public async Task BulkSaveProductDiscoutAsync(IEnumerable<ProductDiscount> productDiscounts)
        {
            try
            {
                if (productDiscounts == null || !productDiscounts.Any())
                    return;

                foreach (var productDiscount in productDiscounts)
                {
                    await SaveProductDiscountAsync(productDiscount);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> RemoveProductDiscountAsync(int productDiscountID)
        {
            try
            {
                using (var conn = new SqlConnection(GetConnectionString))
                {
                    const string sql = "DELETE FROM [dbo].[ProductDiscounts] WHERE Id = @ProductDiscountID";

                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("ProductDiscountID", productDiscountID);
                        
                        var result = await cmd.ExecuteNonQueryAsync();
                        return result > 0;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
