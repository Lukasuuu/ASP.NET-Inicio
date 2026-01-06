using Microsoft.AspNetCore.Mvc;

namespace Lixooo.Controllers
{
    public class Util : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
