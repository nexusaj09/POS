using FluentMigrator;

namespace POS.Database.Migrator.Attributes;

public class DbMigrationAttribute : MigrationAttribute
{
    public DbMigrationAttribute(long version, int year, int month, int day, int hour, int minute, string author)
    : base(CalculateValue(version, year, month, day, hour, minute))
    {
        Author = author;
    }

    public string Author { get; private set; }

    private static long CalculateValue(long version, int year, int month, int day, int hour, int minute)
    {
        return version * 1000000000000L + year * 100000000L + month * 1000000L + day * 10000L + hour * 100L + minute;
    }
}
