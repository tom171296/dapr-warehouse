using Microsoft.AspNetCore.Mvc;
using System;
using WarehouseManagementService.Events;

namespace WarehouseManagementService.Controllers
{
    [ApiController]
    [Route("")]
    public class StockController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult test(){
            return Ok();
        }

        [HttpPost("entrysensor")]
        public IActionResult StockEntryAsync(StockDelivered stockDelivered)
        {
            Console.WriteLine("received message via Dapr");
            return Ok();
        }
    }
}