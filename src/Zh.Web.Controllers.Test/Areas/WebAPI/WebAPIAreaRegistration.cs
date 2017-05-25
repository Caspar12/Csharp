using System.Web.Mvc;

namespace Zh.Web.Controllers.Test.Areas.WebAPI
{
    public class WebAPIAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "WebAPI";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                  "Zh_Web_WebAPI_default",
                  "WebAPI/{controller}/{action}/{id}",
                  new { action = "Index", id = UrlParameter.Optional },
                  new string[] { "Zh.Web.Controllers.Test.Areas.WebAPI.Controllers", "Zh.Web.Controllers.Areas.WebAPI.Controllers" }
              );
        }
    }
}
