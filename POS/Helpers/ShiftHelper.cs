using POS.Classes;
using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace POS.Helpers
{
    public class ShiftHelper : DatabaseConnection
    {
        public async Task<EmployeeShift> StartShiftAsync(EmployeeShift employee)
        {
			try
			{                
                using (var conn = new SqlConnection(GetConnectionString))
                {
                    var sql = @"
                        INSERT INTO EmployeeShifts (
                            EmployeeID, StartTime, TotalCashSalesShift,
                            TotalGcashSalesShift, CreatedByID
                        ) VALUES (
                            @EmployeeID, @StartTime, @TotalCashSalesShift,
                            @TotalGcashSalesShift, @CreatedByID
                        )

                        SELECT SCOPE_IDENTITY();
                    ";

                    conn.Open();

                    using (var cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("EmployeeID", employee.EmployeeID);
                        cmd.Parameters.AddWithValue("StartTime", employee.StartTime);
                        cmd.Parameters.AddWithValue("TotalCashSalesShift", employee.TotalCashSalesShift);
                        cmd.Parameters.AddWithValue("TotalGcashSalesShift", employee.TotalGcashSalesShift);
                        cmd.Parameters.AddWithValue("CreatedByID", employee.CreatedByID);
                        var id = Convert.ToInt32(await cmd.ExecuteScalarAsync());

                        employee.ID = id;

                        return employee;
                    }
                }                
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
