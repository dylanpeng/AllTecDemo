using System.Web;
using System.Web.Mvc;

namespace MVCAuthorizeTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //全局注册filter
            filters.Add(new FormAuthorizeAttribute());
        }
    }
}
