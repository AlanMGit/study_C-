using System.Web;
using System.Web.Mvc;

namespace Dev_app_web_asp_MVC_entity_framework
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
