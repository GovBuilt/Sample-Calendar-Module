using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Navigation;
using OrchardCore.Security.Permissions;
using Sample.Calendar.Indexes;
using YesSql.Indexes;


namespace Sample.Calendar;

public class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IPermissionProvider, Permissions>();
        services.AddScoped<INavigationProvider, AdminMenu>();
        services.AddSingleton<IIndexProvider, CalendarIndexProvider>();
    }
}
