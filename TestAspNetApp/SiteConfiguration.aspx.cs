using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAspNetApp
{
    public partial class SiteConfiguration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AssemblyNameLabel.Text =
                Assembly.GetExecutingAssembly().GetName().ToString();

            VersionLabel.Text =
                Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}