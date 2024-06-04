using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NorthWND_Models.Entities.Concreate;
using NorthWND_UI.Areas.AdminPanel.ActionFilter;

namespace NorthWND_UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    [CheckLogInSession]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            var jsonStr = HttpContext.Session.GetString("ActiveUser");
           

            var emp = JsonConvert.DeserializeObject<Employee>(jsonStr);
            return View(emp);
        }

        // n tane controller eklesekte 
    }
}
