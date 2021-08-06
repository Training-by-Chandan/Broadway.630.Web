using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Broadway._630.Web.Reports
{
    public partial class Report1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    rvSiteMapping.Height = Unit.Pixel(600);
                    rvSiteMapping.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;

                    rvSiteMapping.ServerReport.ReportServerUrl = new Uri("https://localhost/reportserver"); // Add the Reporting Server URL
                    rvSiteMapping.ServerReport.ReportPath = Request.QueryString.Get("path");

                    rvSiteMapping.ServerReport.Refresh();
                }
                catch (Exception ex)
                {
                }
            }
        }
    }
}