using POS.Database.Migrator.Attributes;
using POS.Database.Migrator.Extensions;

namespace POS.Database.Migrator.Migrations._2023._04;

[DbMigration(1, 2023, 04, 26, 17, 26, "rbutad")]
public class Migration042620231726_CreateTopupTransactionTable : BaseDbMigration
{
    public override void Up()
    {
        Create.Table("TopupTransactions")
            .WithColumn("ID").AsInt32().PrimaryKey().Identity()
            .WithColumn("ReferenceNumber").AsString().Nullable()
            .WithColumn("Amount").AsDecimal(18, 4)
            .WithColumn("TopupType").AsInt32()
            .WithColumn("ShiftID").AsInt32()
            .WithAuditableColumns();
    }
}
