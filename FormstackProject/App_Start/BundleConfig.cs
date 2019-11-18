using System.Web;
using System.Web.Optimization;

namespace FormstackProject
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-ui-{version}.js"
                        ));
                        
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",                     
                      "~/Content/formList.css",
                      "~/Content/site.css").IncludeDirectory("~/Content/themes/base","*.css",true));
        }
    }
}
