using Microsoft.AspNetCore.Mvc;

namespace KING_Test.Controllers
{
    public class FlyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
