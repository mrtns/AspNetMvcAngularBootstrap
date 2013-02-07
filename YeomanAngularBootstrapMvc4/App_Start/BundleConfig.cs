using System.Web.Optimization;

namespace YeomanAngularBootstrapMvc4
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles) {
            bundles.Add(new StyleBundle("~/bundles/app").Include("~/styles/app/main.css"));
        }
    }
}