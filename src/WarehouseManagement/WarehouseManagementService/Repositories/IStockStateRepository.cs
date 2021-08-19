using WarehouseManagementService.Models;

namespace WarehouseManagementService.Repositories;
public interface IStockStateRepository
{
    Task SaveWarehouseState(StockState stockState);
}
