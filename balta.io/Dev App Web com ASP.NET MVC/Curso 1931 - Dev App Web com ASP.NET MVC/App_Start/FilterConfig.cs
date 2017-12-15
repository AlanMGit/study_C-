using System.Web;
using System.Web.Mvc;

namespace Curso_1931___Dev_App_Web_com_ASP.NET_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
