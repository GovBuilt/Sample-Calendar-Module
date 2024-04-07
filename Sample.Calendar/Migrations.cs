using OrchardCore.Data.Migration;
using OrchardCore.Recipes.Services;
using Sample.Calendar.Indexes;
using System.Threading.Tasks;
using YesSql.Sql;

namespace Sample.Calendar
{
    public class Migrations : DataMigration
    {
        private readonly IRecipeMigrator _recipeMigrator;

        public Migrations(IRecipeMigrator recipeMigrator) => _recipeMigrator = recipeMigrator;

        public async Task<int> CreateAsync()
        {
            await _recipeMigrator.ExecuteAsync("sample.calendar.recipe.json", this);
            return 1;
        }

        public int Create()
        {
            SchemaBuilder.CreateMapIndexTableAsync<CalendarIndex>(table => table
            .Column<string>("ContentItemId", x => x.WithLength(26))
            );

            SchemaBuilder.AlterTableAsync("CalendarIndex", table => table
            .CreateIndex("IDX_CalendarIndex_ContentItemId", "ContentItemId")
            );

            return 2;
        }
    }
}
