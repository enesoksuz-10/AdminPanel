using Microsoft.AspNetCore.Mvc;

namespace NorthWND_UI.Areas.CustomerPanel.Controllers
{
    [Area("CustomerPanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
