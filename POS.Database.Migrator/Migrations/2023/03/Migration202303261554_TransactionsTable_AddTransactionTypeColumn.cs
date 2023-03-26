using POS.Database.Migrator.Attributes;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 26, 15, 54, "rbutad")]
public class Migration202303261554_TransactionsTable_AddTransactionTypeColumn : BaseDbMigration
{
    public override void Up()
    {
        Alter.Table("Transactions")
            .AddColumn("TransactionType").AsInt32().WithDefaultValue(1);
    }
}
