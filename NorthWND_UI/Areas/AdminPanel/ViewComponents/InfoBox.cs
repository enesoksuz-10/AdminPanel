using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using NorthWND_UI.Areas.AdminPanel.Models;

namespace NorthWND_UI.Areas.AdminPanel.ViewComponents
{
    public class InfoBox  :ViewComponent
    {
        public ViewViewComponentResult Invoke(string BackGround,string Icon , string Count, string Title)
        {
            InfoBoxParameter model = new InfoBoxParameter();
            model.Background = BackGround;
            model.Icon= Icon;
            model.Count= Count;
            model.Title= Title;

            return View(model);
        }
    }
}
