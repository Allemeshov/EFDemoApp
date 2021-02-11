using EFDatabaseFirst.Data;
using Microsoft.AspNetCore.Mvc;

namespace EFDatabaseFirst
{
    [Route("[controller]")]
    [Controller]
    public class PostController : Controller
    {
        private readonly product_marketContext _marketContext;

        public PostController(product_marketContext marketContext)
        {
            _marketContext = marketContext;
        }

        [HttpGet]
        [Route(nameof(Index))]
        public IActionResult Index()
        {
            return Ok("Post controller is active");
        }
        [HttpGet]
        [Route(nameof(Home))]
        public IActionResult Home()
        {
            return Ok("Welcome Home!");
        }
        /*
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    */
    }
}