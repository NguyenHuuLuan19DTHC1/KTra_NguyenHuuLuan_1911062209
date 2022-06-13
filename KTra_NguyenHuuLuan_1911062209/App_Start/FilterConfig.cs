using System.Web;
using System.Web.Mvc;

namespace KTra_NguyenHuuLuan_1911062209
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
