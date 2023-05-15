using POS.Database.Migrator.Attributes;

namespace POS.Database.Migrator.Migrations._2023._05;

[DbMigration(1, 2023, 05, 06, 06, 49, "rbutad")]
public class Migration202305060649_ChangeDataTypeOnDiscountPercentage : BaseDbMigration
{
    public override void Up()
    {
        Alter.Table("Discounts")
            .AlterColumn("DiscountPercentage").AsDecimal(18, 4).WithDefaultValue(0);
    }
}
