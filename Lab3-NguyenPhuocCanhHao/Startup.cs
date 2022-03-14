using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab3_NguyenPhuocCanhHao.Startup))]
namespace Lab3_NguyenPhuocCanhHao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
