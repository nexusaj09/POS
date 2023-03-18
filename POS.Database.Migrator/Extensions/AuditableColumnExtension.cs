using FluentMigrator.Builders.Alter.Table;
using FluentMigrator.Builders.Create.Table;
using FluentMigrator;

namespace POS.Database.Migrator.Extensions;

public static class AuditableColumnExtension
{
    public static ICreateTableWithColumnSyntax WithAuditableColumns(this ICreateTableWithColumnSyntax columnSyntax)
    {
        columnSyntax
            .WithColumn("CreatedByID").AsInt32().ForeignKey("Users", "ID")
            .WithColumn("CreatedDateTime").AsDateTime().WithDefault(SystemMethods.CurrentDateTime)
            .WithColumn("LastModifiedByID").AsInt32().Nullable().ForeignKey("Users", "ID")
            .WithColumn("LastModifiedDateTime").AsDateTime().Nullable();

        return columnSyntax;
    }

    public static IAlterTableAddColumnOrAlterColumnSyntax AddAuditableColumns(this IAlterTableAddColumnOrAlterColumnSyntax columnSyntax)
    {
        columnSyntax
            .AddColumn("CreatedByID").AsInt32().Nullable().ForeignKey("Users", "ID")
            .AddColumn("CreatedDateTime").AsDateTime().Nullable()
            .AddColumn("LastModifiedByID").AsInt32().Nullable().ForeignKey("Users", "ID")
            .AddColumn("LastModifiedDateTime").AsDateTime().Nullable();

        return columnSyntax;
    }
}
