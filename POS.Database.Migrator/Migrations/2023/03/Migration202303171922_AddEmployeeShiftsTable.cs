using POS.Database.Migrator.Attributes;
using POS.Database.Migrator.Extensions;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 17, 19,22,"rbutad")]
public class Migration202303171922_AddEmployeeShiftsTable : BaseDbMigration
{
    public override void Up()
    {
        Create.Table("EmployeeShifts")
            .WithColumn("ID").AsInt32().PrimaryKey().Identity()
            .WithColumn("EmployeeID").AsInt32().ForeignKey("Users", "ID")
            .WithColumn("StartTime").AsDateTime()
            .WithColumn("EndTime").AsDateTime().Nullable()
            .WithColumn("TotalCashSalesShift").AsDecimal(18, 4).WithDefaultValue(0)
            .WithColumn("TotalGcashSalesShift").AsDecimal(18, 4).WithDefaultValue(0)
            .WithAuditableColumns();
    }
}
