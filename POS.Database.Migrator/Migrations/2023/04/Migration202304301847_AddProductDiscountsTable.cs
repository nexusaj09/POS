using POS.Database.Migrator.Attributes;
using POS.Database.Migrator.Extensions;

namespace POS.Database.Migrator.Migrations._2023._04;

[DbMigration(1, 2023, 04, 30, 18, 47, "rbutad")]
public class Migration202304301847_AddProductDiscountsTable : BaseDbMigration
{
    public override void Up()
    {
        Create.Table("ProductDiscounts")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("ProductCode").AsString(50).ForeignKey("Products", "ProductCode")
            .WithColumn("DiscountID").AsInt32().ForeignKey("Discounts", "ID")
            .WithAuditableColumns();
    }
}
