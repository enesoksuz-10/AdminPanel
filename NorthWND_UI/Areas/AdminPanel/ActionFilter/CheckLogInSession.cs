using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace NorthWND_UI.Areas.AdminPanel.ActionFilter
{
    public class CheckLogInSession : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {

            var jsonStr = context.HttpContext.Session.GetString("ActiveUser");
            if (string.IsNullOrEmpty(jsonStr))
            {
                context.Result = new RedirectResult("/AdminPanel/Authentication/LogIn");
            }
        }
    }
}
