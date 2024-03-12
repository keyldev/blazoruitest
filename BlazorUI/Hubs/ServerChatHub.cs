using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace BlazorUI.Hubs
{
    public class ServerChatHub : Hub
    {
        public static string HubUrl = "/chat";

        public async Task Broadcast(string username, string message)
        {
            await Clients.All.SendAsync
                (nameof(Broadcast), username, message);
        }
        public override Task OnConnectedAsync()
        {

            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception? exception)
        {
            Debug.WriteLine(exception);

            return base.OnDisconnectedAsync(exception);
        }
        public ServerChatHub()
        {


        }
    }
}
