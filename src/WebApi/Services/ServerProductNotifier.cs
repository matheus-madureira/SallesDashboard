using Bogus;
using Microsoft.AspNetCore.SignalR;
using WebApi.Hubs;
using WebApi.Models;

namespace WebApi.Services;

public sealed class ServerProductNotifier(
    ILogger<ServerProductNotifier> logger,
    IHubContext<ProductsHub> context)
    : BackgroundService
{
    private readonly ILogger<ServerProductNotifier> _logger = logger;
    private readonly IHubContext<ProductsHub> _context = context;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("ServerProductNotifier started...");

        while (!stoppingToken.IsCancellationRequested)
        {
            var productData = GenerateProductData();
            
            await _context.Clients.All.SendAsync(
                    "ReceiveProduct",
                    productData,
                    cancellationToken: stoppingToken);
        }
    }

    private Product GenerateProductData()
    {
        var faker = new Faker();
        
        return Product.Create(
            faker.Commerce.ProductName(),
            faker.Commerce.Price(100),
            faker.Date.RecentDateOnly().ToString(),
            Collaborator.Create(faker.Person.FullName, faker.Person.Email));
    }
}

