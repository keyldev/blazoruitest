using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace BlazorUI.Hubs
{
    public class ServerChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }
    }
}
