using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WorkEverything.App_Start.Startup))]

namespace WorkEverything.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}