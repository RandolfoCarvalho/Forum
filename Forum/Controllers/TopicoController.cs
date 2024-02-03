using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    public class TopicoController : Controller
    {
        public IActionResult Random()
        {
            return RedirectToAction("Create", "Post");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
