using POS.Classes;
using POS.Extensions;
using POS.Forms;
using POS.Models;
using POS.Panels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Helpers
{
    public class ProductHelper : DatabaseConnection
    {

        public void LoadCategories(ComboBox categories)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT ID, Category FROM Categories ORDER BY ID";
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    categories.DataSource = dt;
                    categories.ValueMember = "ID";
                    categories.DisplayMember = "Category";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {

                conn.Close();
                conn.Dispose();
            }
        }

        public void CreateProduct(Product product)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                if (product.IsExpiring == false)
                {
                    product.ExpirationDate = DateTime.MinValue;
                }

                using (cmd = new SqlCommand())
                {
                    const string sql = @"
                        INSERT INTO Products (
                            ProductCode, Barcode, Description, BrandName, GenericName, Classification,
                            Formulation, Category, UOM, ReOrderQty, Qty, SupplierPrice,
                            FinalPrice, SRP, CreatedByID, CreatedDateTime, LastModifiedByID,
                            LastModifiedDateTime, MarkUp, ExpirationDate, IsExpiring, Location
                        ) VALUES (
                            @ProductCode, @Barcode, @Description, @BrandName, @GenericName, @Classification,
                            @Formulation, @Category, @UOM, @ReOrderQty, @Qty, @SupplierPrice,
                            @FinalPrice, @SRP, @CreatedByID, @CreatedDateTime, @LastModifiedByID,
                            @LastModifiedDateTime, @MarkUp, @ExpirationDate, @IsExpiring, @Location
                        )
                    ";

                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;

                    cmd.Parameters.AddWithValue(@"ProductCode", product.ProductCode);
                    cmd.Parameters.AddWithValue(@"Barcode", product.ProductBarcode);
                    cmd.Parameters.AddWithValue(@"Description", product.Description);
                    cmd.Parameters.AddWithValue(@"BrandName", product.BrandName);
                    cmd.Parameters.AddWithValue(@"GenericName", product.GenericName);
                    cmd.Parameters.AddWithValue(@"Classification", product.Classification);
                    cmd.Parameters.AddWithValue(@"Formulation", product.Formulation);
                    cmd.Parameters.AddWithValue(@"Category", product.Category);
                    cmd.Parameters.AddWithValue(@"UOM", product.UOM);
                    cmd.Parameters.AddWithValue(@"ReOrderQty", product.ReOrderQty);
                    cmd.Parameters.AddWithValue(@"Qty", product.Qty);
                    cmd.Parameters.AddWithValue(@"SupplierPrice", product.SupplierPrice);
                    cmd.Parameters.AddWithValue(@"FinalPrice", product.FinalPrice);
                    cmd.Parameters.AddWithValue(@"SRP", product.SRP);
                    cmd.Parameters.AddWithValue(@"CreatedByID", product.CreatedByID);
                    cmd.Parameters.AddWithValue(@"CreatedDateTime", product.CreatedDateTime);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", product.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", product.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"MarkUp", product.MarkUp);
                    cmd.Parameters.AddWithValue(@"ExpirationDate", product.ExpirationDate);
                    cmd.Parameters.AddWithValue(@"IsExpiring", product.IsExpiring);
                    cmd.Parameters.AddWithValue(@"Location", product.Location);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void LoadProducts(FormProduct formProduct, string search)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                int count = 0;

                formProduct.grdProductList.Rows.Clear();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT ProductCode,Barcode,Description,Location,
                                BrandName,GenericName,Classification,Formulation,
                                Category, UOM,QTY,ReOrderQty,SupplierPrice,SRP,FinalPrice,MarkUp,ExpirationDate,IsExpiring
                                FROM Products WHERE ProductCode LIKE '%" + search + "%' OR Barcode LIKE '%" + search + "%' OR Description LIKE '%" + search + "%' OR Category LIKE '%" + search + "%' ORDER BY ProductCode";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        count++;

                        string expirationDate = Convert.ToBoolean(dr["IsExpiring"]) == true ? Convert.ToDateTime(dr["ExpirationDate"].ToString()).ToShortDateString() : string.Empty;
                        

                        

                        formProduct.grdProductList.Rows.Add(count, dr["ProductCode"].ToString(), dr["Barcode"].ToString(), dr["Description"].ToString(),
                                dr["Location"].ToString(),dr["BrandName"].ToString(), dr["GenericName"].ToString(), dr["Classification"].ToString(), dr["Formulation"].ToString(), dr["Category"].ToString(),
                                dr["UOM"].ToString(), dr["QTY"], dr["ReOrderQty"], dr["SupplierPrice"], dr["SRP"], dr["FinalPrice"], dr["MarkUp"].ToString(),expirationDate, Convert.ToBoolean(dr["IsExpiring"]));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }

        public int CountProducts()
        {
            int count = 0;

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT COUNT(*) as Rows FROM PRODUCTS";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = Convert.ToInt32(dr["Rows"].ToString());
                    }
                }

                return count;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return count;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }




        }

        public int CountTotalProducts()
        {
            int count = 0;

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT SUM(Qty) as TotalQty FROM PRODUCTS";
                    var value = cmd.ExecuteScalar();

                    count = !value.ToString().Equals("") ? Convert.ToInt32(value.ToString()) : 0;
                }

                return count;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return count;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public int CountTotalReStockQty()
        {
            int count = 0;

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                { 
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT Count(*) as TotalReStock FROM PRODUCTS  WHERE Qty > 0 AND Qty <= ReOrderQty ";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = Convert.ToInt32(dr["TotalReStock"].ToString());
                    }
                }

                return count;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return count;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }
        public int CountTotalOutofStock()
        {
            int count = 0;

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT Count(*) as OutOfStock FROM PRODUCTS WHERE Qty = 0 ";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = Convert.ToInt32(dr["OutOfStock"].ToString());
                    }
                }

                return count;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return count;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }

        public int CountTotalExpiredStock()
        {
            int count = 0;

            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT Count(*) as Expired FROM PRODUCTS WHERE CAST(ExpirationDate as DATE) < GETDATE() AND IsExpiring = 1";
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        count = Convert.ToInt32(dr["Expired"].ToString());
                    }
                }

                return count;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                return count;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }


        public void DeleteProduct(string productCode)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"DELETE FROM PRODUCTS WHERE ProductCode = @ProductCode";
                    cmd.Parameters.AddWithValue(@"ProductCode", productCode);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"UPDATE Products SET Barcode = @Barcode, Description = @Description,
                                        BrandName = @BrandName, GenericName = @GenericName, Classification = @Classification,
                                        Formulation = @Formulation, Category = @Category, UOM = @UOM,
                                        ReOrderQty = @ReOrderQty, Qty = @Qty, SupplierPrice = @SupplierPrice,
                                        FinalPrice = @FinalPrice, SRP = @SRP, LastModifiedDateTime = @LastModifiedDateTime,
                                        MarkUp = @MarkUp, LastModifiedByID = @LastModifiedByID, ExpirationDate = @ExpirationDate,
                                        IsExpiring = @IsExpiring, Location = @Location WHERE ProductCode = @ProductCode";
                    cmd.Parameters.AddWithValue(@"ProductCode", product.ProductCode);
                    cmd.Parameters.AddWithValue(@"Barcode", product.ProductBarcode);
                    cmd.Parameters.AddWithValue(@"Description", product.Description);
                    cmd.Parameters.AddWithValue(@"BrandName", product.BrandName);
                    cmd.Parameters.AddWithValue(@"GenericName", product.GenericName);
                    cmd.Parameters.AddWithValue(@"Classification", product.Classification);
                    cmd.Parameters.AddWithValue(@"Formulation", product.Formulation);
                    cmd.Parameters.AddWithValue(@"Category", product.Category);
                    cmd.Parameters.AddWithValue(@"UOM", product.UOM);
                    cmd.Parameters.AddWithValue(@"ReOrderQty", product.ReOrderQty);
                    cmd.Parameters.AddWithValue(@"Qty", product.Qty);
                    cmd.Parameters.AddWithValue(@"SupplierPrice", product.SupplierPrice);
                    cmd.Parameters.AddWithValue(@"FinalPrice", product.FinalPrice);
                    cmd.Parameters.AddWithValue(@"SRP", product.SRP);
                    cmd.Parameters.AddWithValue(@"LastModifiedByID", product.LastModifiedByID);
                    cmd.Parameters.AddWithValue(@"LastModifiedDateTime", product.LastModifiedDateTime);
                    cmd.Parameters.AddWithValue(@"MarkUp", product.MarkUp);
                    cmd.Parameters.AddWithValue(@"ExpirationDate", product.ExpirationDate);
                    cmd.Parameters.AddWithValue(@"IsExpiring", product.IsExpiring);
                    cmd.Parameters.AddWithValue(@"Location", product.Location);
                    cmd.ExecuteNonQuery();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }


        public bool IsExisting(string productCode)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT ProductCode FROM Products WHERE LTRIM(RTRIM(ProductCode)) = LTRIM(RTRIM('" + productCode + "')) ";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }
        public bool IsExistingBarcode(string Barcode)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = @"SELECT Barcode FROM Products WHERE LTRIM(RTRIM(Barcode)) = LTRIM(RTRIM('" + Barcode + "')) ";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }

        public void LoadProductPanel(PanelProducts panelProduct,string search)
        {
            try
            {
                conn.Close();
                conn.Dispose();

                connection();

                int count = 0;

                panelProduct.grdProductList.Rows.Clear();

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"SELECT ProductCode,Barcode,Description,Location,                                
                                Category, QTY,ReOrderQty,SupplierPrice,SRP,FinalPrice
                                FROM Products WHERE ProductCode LIKE '%" + search + "%' OR Barcode LIKE '%" + search + "%' OR Description LIKE '%" + search + "%' ORDER BY ProductCode";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        count++;
                        panelProduct.grdProductList.Rows.Add(count, dr["ProductCode"].ToString(), dr["Barcode"].ToString(), dr["Description"].ToString(),
                                dr["Location"].ToString(), dr["Category"].ToString(), dr["QTY"], dr["ReOrderQty"], dr["SupplierPrice"], dr["SRP"], dr["FinalPrice"]);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close();
                conn.Close();
                conn.Dispose();
            }
        }

        public async Task<IEnumerable<ProductDiscount>> GetProductDiscountsAsync(string productCode)
        {
            try
            {
                var productDiscounts = new List<ProductDiscount>();

                using (var conn = new SqlConnection(GetConnectionString))
                {
                    const string sql = @"
                        SELECT
	                        pd.Id,
	                        pd.ProductCode,
	                        pd.DiscountID,
	                        d.[Description],
	                        d.DiscountPercentage
                        FROM ProductDiscounts pd
	                        INNER JOIN Discounts d ON d.ID = pd.DiscountID
                        WHERE pd.ProductCode = @ProductCode
                    ";

                    conn.Open();
                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("ProductCode", productCode);

                        var reader = await cmd.ExecuteReaderAsync();
                        productDiscounts = reader.ConvertToList<ProductDiscount>();
                    }
                }

                if (!productDiscounts.Any())
                    return Enumerable.Empty<ProductDiscount>();

                return productDiscounts;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}