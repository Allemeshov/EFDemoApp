using EFDatabaseFirst.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFDatabaseFirst
{
    [Route("[controller]")]
    [Controller]
    public class ClientController : Controller
    {
        private readonly product_marketContext _marketContext;

        public ClientController(product_marketContext marketContext)
        {
            _marketContext = marketContext;
        }

        [HttpGet]
        [Route(nameof(Index))]
        public IActionResult Index()
        {
            return Ok("Client controller is active!");
        }
    }
}