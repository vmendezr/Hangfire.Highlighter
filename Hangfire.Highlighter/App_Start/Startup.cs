using Hangfire;
using Microsoft.Owin;
using Owin;

// Configure Owin configuration entry point
[assembly: OwinStartup(typeof(Hangfire.Highlighter.App_Start.Startup), "Configure")]
namespace Hangfire.Highlighter.App_Start
{
    public class Startup
    {
        public void Configure(IAppBuilder app)
        {
            GlobalConfiguration.Configuration.UseSqlServerStorage("HighlighterDb");

            app.UseHangfireDashboard();
            app.UseHangfireServer();
        }
    }
}