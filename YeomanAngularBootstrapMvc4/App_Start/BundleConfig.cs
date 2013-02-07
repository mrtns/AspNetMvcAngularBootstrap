using System.Web.Optimization;

namespace YeomanAngularBootstrapMvc4
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/bundles/app").Include("~/styles/vendor/bootstrap/bootstrap.css", "~/styles/app/main.css"));

            bundles.Add(new ScriptBundle("~/bundles/myApp").Include("~/scripts/app/myApp/myApp.js", "~/scripts/app/myApp/aboutCtrl.js", "~/scripts/app/myApp/homeCtrl.js", "~/scripts/app/myApp/contactCtrl.js"));
        }
    }
}