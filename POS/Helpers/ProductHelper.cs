﻿using POS.Classes;
using POS.Forms;
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

                using (cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = @"INSERT INTO Products
                                                           (
                                                            ProductCode,
                                                            Barcode,
                                                            Description,
                                                            BrandName,
                                                            GenericName,
                                                            Classification,
                                                            Formulation,
                                                            Category,
                                                            UOM,
                                                            ReOrderQty,
                                                            Qty,
                                                            SupplierPrice,
                                                            FinalPrice,
                                                            SRP,
                                                            CreatedByID,
                                                            CreatedDateTime,
                                                            LastModifiedByID,
                                                            LastModifiedDateTime,
                                                            MarkUp
                                                           )
                                                    VALUES
                                                           (
                                                            @ProductCode,
                                                            @Barcode,
                                                            @Description,
                                                            @BrandName,
                                                            @GenericName,
                                                            @Classification,
                                                            @Formulation,
                                                            @Category,
                                                            @UOM,
                                                            @ReOrderQty,
                                                            @Qty,
                                                            @SupplierPrice,
                                                            @FinalPrice,
                                                            @SRP,
                                                            @CreatedByID,
                                                            @CreatedDateTime,
                                                            @LastModifiedByID,
                                                            @LastModifiedDateTime,
                                                            @MarkUp                                       
                                                            )";
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
                    cmd.CommandText = @"SELECT ProductCode,Barcode,Description,
                                BrandName,GenericName,Classification,Formulation,
                                Category, UOM,QTY,ReOrderQty,SupplierPrice,SRP,FinalPrice,MarkUp 
                                FROM Products WHERE ProductCode LIKE '%" + search + "%' OR Barcode LIKE '%" + search + "%' OR Description LIKE '%" + search + "%' ORDER BY ProductCode";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        count++;
                        formProduct.grdProductList.Rows.Add(count, dr["ProductCode"].ToString(), dr["Barcode"].ToString(), dr["Description"].ToString(),
                                dr["BrandName"].ToString(), dr["GenericName"].ToString(), dr["Classification"].ToString(), dr["Formulation"].ToString(), dr["Category"].ToString(),
                                dr["UOM"].ToString(), dr["QTY"].ToString(), dr["ReOrderQty"].ToString(), dr["SupplierPrice"].ToString(), dr["SRP"].ToString(), dr["FinalPrice"].ToString(), dr["MarkUp"].ToString());
                    }

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
                    cmd.CommandText = @"SELECT Count(*) as TotalReStock FROM PRODUCTS  WHERE Qty <= ReOrderQty";
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
                conn.Close();
                conn.Dispose();
            }
        }

        public void DeleteProdut(string productCode)
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
                                        MarkUp = @MarkUp, LastModifiedByID = @LastModifiedByID WHERE ProductCode = @ProductCode";
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
    }
}