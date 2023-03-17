using FluentMigrator.Runner;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POS.Database.Migrator.Migrations;

var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

var builder = new ConfigurationBuilder()
    .AddJsonFile($"appsettings.json", false, true)
    .AddEnvironmentVariables();

var configuration = builder.Build();
var connectionString = configuration.GetConnectionString("DefaultConnection");

var service = new ServiceCollection()
    .AddFluentMigratorCore()
    .ConfigureRunner(builder =>
        builder
            .AddSqlServer()
            .WithGlobalConnectionString(connectionString)
            .ScanIn(typeof(BaseDbMigration).Assembly).For.Migrations()
        )
    .AddLogging(loggingBuilder => loggingBuilder.AddFluentMigratorConsole())
    .BuildServiceProvider(false);

using var scope = service.CreateScope();
var runner = scope.ServiceProvider.GetRequiredService<IMigrationRunner>();
runner.MigrateUp();