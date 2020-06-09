using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FormulaWeb_ASP.Startup))]
namespace FormulaWeb_ASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
