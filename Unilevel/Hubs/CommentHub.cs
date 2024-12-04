using Microsoft.AspNetCore.SignalR;
namespace Unilevel.Hubs
{
    public class CommentHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            
            await Clients.All.SendAsync("ReceiveComment", user, message);
        }
    }

}
