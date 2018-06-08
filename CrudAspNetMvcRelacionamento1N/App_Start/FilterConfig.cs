using System.Web;
using System.Web.Mvc;

namespace CrudAspNetMvcRelacionamento1N
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
