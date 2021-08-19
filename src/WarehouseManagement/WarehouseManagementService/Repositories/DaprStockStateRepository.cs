using Dapr.Client;
using WarehouseManagementService.Models;

namespace WarehouseManagementService.Repositories;
public class DaprStockStateRepository : IStockStateRepository
{
    private const string STOCK_STATE_STORE = "stockStateStore";

    private readonly DaprClient _daprClient;

    public DaprStockStateRepository(DaprClient daprClient)
    {
        _daprClient = daprClient;
    }

    public async Task SaveWarehouseState(StockState stockState)
    {
        await _daprClient.SaveStateAsync(STOCK_STATE_STORE, stockState.Id, stockState);
    }
}
