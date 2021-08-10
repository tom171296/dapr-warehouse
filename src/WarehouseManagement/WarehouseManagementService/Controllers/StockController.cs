using Microsoft.AspNetCore.Mvc;

namespace WarehouseManagementService.Controllers
{
    [Controller]
    public class StockController : ControllerBase
    {
        [HttpPost("entrysensor")]
        public IActionResult StockEntryAsync(StockDelivered stockDelivered)
        {
            return Ok();
        }
    }
}
