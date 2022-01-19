using Microsoft.AspNetCore.SignalR;
using Writer.Shared;

namespace Writer.Server.Hubs
{
    public class MessageHub : Hub
    {
        public async Task SendMessage(Message message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);        
        }
    }
}