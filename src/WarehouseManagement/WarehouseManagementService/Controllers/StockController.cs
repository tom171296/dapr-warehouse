using Microsoft.AspNetCore.Mvc;
using System;
using WarehouseManagementService.Events;

namespace WarehouseManagementService.Controllers
{
    [Controller]
    public class StockController : ControllerBase
    {
        [HttpPost("entrysensor")]
        public IActionResult StockEntryAsync(StockDelivered stockDelivered)
        {
            Console.WriteLine("received message via Dapr");
            return Ok();
        }
    }
}