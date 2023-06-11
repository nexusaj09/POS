using FluentMigrator;
using POS.Database.Migrator.Attributes;
using POS.Database.Migrator.Extensions;

namespace POS.Database.Migrator.Migrations._2023._06;

[DbMigration(1, 2023, 06, 11, 17, 26, "rbutad")]
public class Migration202306111726_CreateGCashCashOutsTable : BaseDbMigration
{
    public override void Up()
    {
        Create.Table("GCashCashOuts")
            .WithColumn("Uid").AsGuid().PrimaryKey().WithDefault(SystemMethods.NewGuid)
            .WithColumn("ReferenceNumber").AsString().Unique()
            .WithColumn("Amount").AsDecimal(18, 4)
            .WithColumn("Fee").AsDecimal(18, 4).WithDefaultValue(0)
            .WithColumn("IsFeePaySeparately").AsBoolean().WithDefaultValue(true)
            .WithColumn("IsAmountIncludesFee").AsBoolean().WithDefaultValue(false)
            .WithColumn("IsFeeDeductedOnCashOutAmount").AsBoolean().WithDefaultValue(false)
            .WithAuditableColumns();
    }
}
