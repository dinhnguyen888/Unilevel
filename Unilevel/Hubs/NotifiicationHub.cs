using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.SignalR;

namespace Unilevel.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task SendNotification(string content)
        {

            await Clients.All.SendAsync("ReceiveMessage", content);
        }
    }
}
