using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Newtonsoft.Json;
using NorthWND_Models.Entities.Concreate;

namespace NorthWND_UI.Areas.AdminPanel.ViewComponents
{
    public class PanelSide : ViewComponent
    {
        public ViewViewComponentResult Invoke()
        {

            var jsonStr =HttpContext.Session.GetString("ActiveUser");
            Employee employee = null;

            if (!string.IsNullOrEmpty(jsonStr))
            {
                employee = JsonConvert.DeserializeObject<Employee>(jsonStr);
            }
            return View(employee);
        }
    }
}
