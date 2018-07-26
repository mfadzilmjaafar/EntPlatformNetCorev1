using Microsoft.AspNetCore.Mvc;
using EntPlatform.Services.Models;
using System.Linq;

namespace EntPlatform.Services.Controllers
{
    public class CountryController : Controller
    {
        private readonly EntPlaformContext _context;
        public CountryController(EntPlaformContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listofcountry = from x in _context.Country
                                orderby x.Name
                                select x;


            return View(listofcountry.ToList());
        }
    }
}