using System.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(typeof(MEDemo.App_Start.BootstrapBundleConfig), "RegisterBundles")]

namespace MEDemo.App_Start
{
	public class BootmetroBundleConfig
	{
		public static void RegisterBundles()
		{
			// Add @Styles.Render("~/Content/bootstrap") in the <head/> of your _Layout.cshtml view
			// Add @Scripts.Render("~/bundles/bootstrap") after jQuery in your _Layout.cshtml view
			// When <compilation debug="true" />, MVC4 will render the full readable version. When set to <compilation debug="false" />, the minified version will be rendered automatically
            BundleTable.Bundles.Add(new StyleBundle("~/Content/bootmetro").Include(
                "~/Content/bootmetro-0.6.0/css/bootstrap.css",
                "~/Content/bootmetro-0.6.0/css/bootstrap-responsive.css",
                "~/Content/bootmetro-0.6.0/css/bootmetro.css",
                "~/Content/bootmetro-0.6.0/css/bootmetro-tiles.css",
                "~/Content/bootmetro-0.6.0/css/bootmetro-charms.css",
                "~/Content/bootmetro-0.6.0/css/metro-ui-light.css",
                "~/Content/bootmetro-0.6.0/css/icomoon.css",
                "~/Scripts/bootmetro-0.6.0/google-code-prettify/prettify.css"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/bootmetro").Include(
                "~/Scripts/bootmetro-0.6.0/knockout-2.1.0.debug.js",
                "~/Scripts/bootmetro-0.6.0/google-code-prettify/prettify.js",
                "~/Scripts/bootmetro-0.6.0/jquery.mousewheel.js",
                "~/Scripts/bootmetro-0.6.0/jquery.scrollTo.js",
                "~/Scripts/bootmetro-0.6.0/bootstrap.js",
                "~/Scripts/bootmetro-0.6.0/bootmetro.js",
                "~/Scripts/bootmetro-0.6.0/bootmetro-charms.js",
                "~/Scripts/bootmetro-0.6.0/holder.js"));

            BundleTable.Bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/bootmetro-0.6.0/modernizr-*"));
		}
	}
}