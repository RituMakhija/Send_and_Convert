using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConvertToXML_and_SendMail.Startup))]
namespace ConvertToXML_and_SendMail
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
