using Microsoft.AspNetCore.Mvc;

namespace WarehouseManagementService.Controllers
{
    [Controller]
    public class StockController : ControllerBase
    {
        [HttpPost("entrysensor")]
        public IActionResult StockEntryAsync()
        {
            return Ok();
        }
    }
}
