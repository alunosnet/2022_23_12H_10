using System.Web;
using System.Web.Mvc;

namespace GYMdoJime2_Modulo17E
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
