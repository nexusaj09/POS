using FluentMigrator;

namespace POS.Database.Migrator.Migrations;

public abstract class BaseDbMigration : Migration
{
    public override void Down()
    {
        // DO NOT IMPLEMENT ANY
        throw new NotImplementedException();
    }
}
