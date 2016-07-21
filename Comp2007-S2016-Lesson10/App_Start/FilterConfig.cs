using System.Web;
using System.Web.Mvc;

namespace Comp2007_S2016_Lesson10 {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
