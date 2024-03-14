using System.Web;
using System.Web.Mvc;

namespace _2180608005_LeNguyenNhatTan
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
