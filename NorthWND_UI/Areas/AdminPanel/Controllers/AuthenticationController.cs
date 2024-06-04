using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NorthWND_BusinessLayer.Concreate;
using NorthWND_UI.Areas.AdminPanel.Models;

namespace NorthWND_UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AuthenticationController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public JsonResult LogIn(LogInDto dto)
        {

            var empBS = new EmployeeBS();
            var emp = empBS.LogIn(dto.UserName, dto.Password);
            if (emp !=null)
            {
                var jsonStr = JsonConvert.SerializeObject(emp);
                HttpContext.Session.SetString("ActiveUser", jsonStr);
                return Json(new { Result = true });
            }
            else
            {
                return Json(new { Result = false, Message = "Hatalı Giriş Yapıldı." });
            }
            

        }
    }
}
