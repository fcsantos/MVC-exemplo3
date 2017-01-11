using Owin;
using Microsoft.Owin;

//mapeamento para ativar as configurações do OWIN
[assembly:OwinStartup(typeof(ChatSignalR.Startup))]
namespace ChatSignalR
{
    public class Startup
    {
        //método de configuração as tecnologias
        public void Configuration(IAppBuilder app)
        {
            //habilitar o signalR
            app.MapSignalR();
        }
    }
}
