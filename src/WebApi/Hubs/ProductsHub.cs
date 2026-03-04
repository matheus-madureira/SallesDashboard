using Microsoft.AspNetCore.SignalR;

namespace WebApi.Hubs;

public class ProductsHub : Hub
{
    public async Task Join(string productId)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, productId);
    }

    public async Task Leave(string productId)
    {
        await Groups.RemoveFromGroupAsync(Context.ConnectionId, productId);
    }
}
