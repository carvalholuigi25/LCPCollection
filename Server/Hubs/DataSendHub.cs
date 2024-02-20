using Microsoft.AspNetCore.SignalR;

namespace LCPCollection.Server.Hubs
{
    public class DataSendHub : Hub
    {
        public async Task SendMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }
    }
}
