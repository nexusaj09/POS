using POS.Database.Migrator.Attributes;

namespace POS.Database.Migrator.Migrations._2023._03;

[DbMigration(1, 2023, 03, 26, 17, 18, "rbutad")]
public class Migration202303261718_TransactionsTable_RenameTransactionTypeColumnToPaymentType : BaseDbMigration
{
    public override void Up()
    {
        Execute.Sql(@"
ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [DF_Transactions_TransactionType]
GO

ALTER TABLE [Transactions]
DROP COLUMN TransactionType
");

        Alter.Table("Transactions")
            .AddColumn("PaymentType").AsInt32().WithDefaultValue(1);
    }
}
