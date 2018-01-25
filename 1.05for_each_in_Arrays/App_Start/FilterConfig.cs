using System.Web;
using System.Web.Mvc;

namespace _1._05for_each_in_Arrays
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
