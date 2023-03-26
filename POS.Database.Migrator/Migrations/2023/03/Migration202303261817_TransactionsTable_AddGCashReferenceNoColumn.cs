using POS.Database.Migrator.Attributes;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 26, 18, 17, "rbutad")]
public class Migration202303261817_TransactionsTable_AddGCashReferenceNoColumn : BaseDbMigration
{
    public override void Up()
    {
        Alter.Table("Transactions")
            .AddColumn("GCashReferenceNo").AsString().Nullable();
    }
}
