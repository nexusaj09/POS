using POS.Classes;
using POS.Extensions;
using POS.Helpers;
using POS.Models;
using POS.Models.Product;
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

        //public async Task<IEnumerable<EligibleProductDiscount>> GetProductDiscountsForSelectionAsync(int discountID)
        //{
        //    try
        //    {
        //        var products = new List<EligibleProductDiscount>();

        //        using (var conn = new SqlConnection(GetConnectionString))
        //        {
        //            const string sql = @"
        //                SELECT
        //                    CAST(1 AS BIT) AS IsSelected,
        //                    p.ProductCode,
        //                    p.[Description],
        //                    p.FinalPrice AS UnitAmount,
        //                    p.FinalPrice * (d.DiscountPercentage / 100) AS DiscountAmount,
        //                    p.FinalPrice- (p.FinalPrice * (d.DiscountPercentage / 100)) AS DiscountedUnitAmount
        //                FROM [ProductDiscounts] pd
        //                    INNER JOIN Products p ON p.ProductCode = pd.ProductCode
        //                    INNER JOIN Discounts d ON d.ID = pd.DiscountID
        //                WHERE pd.DiscountID = @DiscountID
        //            ";

        //            conn.Open();
        //            using (var cmd = new SqlCommand(sql, conn))
        //            {
        //                cmd.Parameters.AddWithValue("DiscountID", discountID);

        //                var data = await cmd.ExecuteReaderAsync();
        //                products = data.ConvertToList<EligibleProductDiscount>();
        //            }
        //        }

        //        return products;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

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
