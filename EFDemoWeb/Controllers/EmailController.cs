using System.Linq;
using EFDataAccessLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFDemoWeb.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        private PeopleContext _context;

        public EmailController(PeopleContext context)
        {
            _context = context;
        }

        // GET
        public IActionResult Index()
        {
            var addresses = _context.Addresses.Include(a => a.Person).ToList();

            return Ok(addresses.ToString());
        }
    }
}