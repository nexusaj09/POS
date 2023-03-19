using POS.Database.Migrator.Attributes;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 19, 12, 50, "rbutad")]
public class Migration202303191250_RenameTypeColumnInGCashTransactionsTable : BaseDbMigration
{
    public override void Up()
    {
        Execute.Sql(@"
ALTER TABLE [dbo].[GCashTransactions]
DROP COLUMN [Type];

ALTER TABLE [dbo].[GCashTransactions]
ADD TransactionType INT NOT NULL;
");
    }
}
