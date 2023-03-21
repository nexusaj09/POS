using POS.Database.Migrator.Attributes;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 21, 19, 25, "rbutad")]
public class Migration202303211925_GCashTransactionsTable_AlterModifiedColumnsToBeNullable : BaseDbMigration
{
    public override void Up()
    {
        Execute.Sql(@"
ALTER TABLE [GCashTransactions]
ALTER COLUMN LastModifiedByID INT NULL

ALTER TABLE [GCashTransactions]
ALTER COLUMN LastModifiedDateTime DATETIME NULL
");
    }
}
