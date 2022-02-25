using System.Web;
using System.Web.Mvc;

namespace FlexBox_Web_Site_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
