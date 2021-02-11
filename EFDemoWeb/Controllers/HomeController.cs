using Microsoft.AspNetCore.Mvc;

namespace EFDemoWeb.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        // GET
        public IActionResult Index()
        {
            return Ok("Home index");
        }
    }
}