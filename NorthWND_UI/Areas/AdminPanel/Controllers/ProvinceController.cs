using Microsoft.AspNetCore.Mvc;
using NorthWND_BusinessLayer.Concreate;

namespace NorthWND_UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProvinceController : Controller
    {
        [HttpPost]
        public JsonResult GetByCities(int id)
        {
            var provinceBs = new ProvinceBS();
            var provinces = provinceBs.GetByCities(id);
            if (provinces != null)
            {
                return Json(new { Response = true, Province = provinces });

            }
            else
            {
                return Json(new { Response = false, Message = "Bir Hata oluştu." });
            }
        }
    }
}
