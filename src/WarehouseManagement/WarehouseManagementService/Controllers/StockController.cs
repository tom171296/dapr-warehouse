using Microsoft.AspNetCore.Mvc;
using WarehouseManagementService.Events;
using WarehouseManagementService.Models;
using WarehouseManagementService.Repositories;

[ApiController]
[Route("")]
public class StockController : ControllerBase
{
    private readonly ILogger<StockController> _logger;
    private readonly IStockStateRepository _stockStateRepository;

    public StockController(
        ILogger<StockController> logger,
        IStockStateRepository stockStateRepository)
    {
        _logger = logger;
        _stockStateRepository = stockStateRepository;
    }

    [HttpPost("entrysensor")]
    public async Task<IActionResult> StockEntryAsync(StockDelivered stockDelivered)
    {
        try
        {
            _logger.LogInformation("Received new stock delivery {1}", stockDelivered.Id);

            var stockState = new StockState
            {
                Id = stockDelivered.Id
            };

            await _stockStateRepository.SaveWarehouseState(stockState);

            return Ok();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occured while processing stock delivery");
            return StatusCode(500); 
        }
        
    }
}
