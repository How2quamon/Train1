using Microsoft.AspNetCore.Mvc;

namespace Train1.Controllers
{
    public class DatVeController : Controller
    {
        public IActionResult Index()
        {
            return View("datve");
        }
    }
}
