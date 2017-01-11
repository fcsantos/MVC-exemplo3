using Microsoft.AspNet.SignalR; //SignalR

namespace ChatSignalR.Messages
{
    //HUB -> conversação
    public class ChatHub : Hub
    {
        //método para gerar uma conversa
        //Send -> método para enviar uma mensagem
        public void Send(string usuario, string mensagem)
        {
            //transmitir a conversa para os ouvintes
            //quem poderá ouvir a conversa é qualquer um que 
            //tenha acesso a este hub
            Clients.All.broadcastMessage(usuario, mensagem);
        }
    }
}
