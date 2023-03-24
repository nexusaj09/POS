using POS.Database.Migrator.Attributes;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 25, 05, 43, "rbutad")]
public class Migration202303250543_GCashTransactionsTable_AddIsNegativeColumn : BaseDbMigration
{
    public override void Up()
    {
        Alter.Table("GCashTransactions")
            .AddColumn("IsNegative").AsBoolean();
    }
}
