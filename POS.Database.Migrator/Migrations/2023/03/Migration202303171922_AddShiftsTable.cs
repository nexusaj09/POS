using FluentMigrator;
using POS.Database.Migrator.Attributes;
using POS.Database.Migrator.Extensions;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 17, 19,22,"rbutad")]
public class Migration202303171922_AddShiftsTable : BaseDbMigration
{
    public override void Up()
    {
        Create.Table("Shifts")
            .WithColumn("ID").AsInt32().PrimaryKey().Identity()
            .WithColumn("PettyCash").AsDecimal(18, 4).WithDefaultValue(0)
            .WithColumn("GCashPettyCash").AsDecimal(18, 4).WithDefaultValue(0)
            .WithColumn("ShiftStartAt").AsDateTime().WithDefault(SystemMethods.CurrentDateTime)
            .WithColumn("ShiftEndAt").AsDateTime().Nullable()
            .WithAuditableColumns();
    }
}
