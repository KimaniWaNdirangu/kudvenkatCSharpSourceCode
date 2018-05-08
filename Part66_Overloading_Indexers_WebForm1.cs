using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kudvenkat.Part66.Overloading_Indexers
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company company = new Company();

            Response.Write("Before Update");
            Response.Write("<br/>");
            Response.Write("Total Number of Male Employees :  " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Number of Female Employees :  " + company["Female"]);

            Response.Write("<br/>");
            Response.Write("<br/>");

            company["Male"] = "Female";

            Response.Write("After Update");
            Response.Write("<br/>");
            Response.Write("Total Number of Male Employees :  " + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Number of Female Employees :  " + company["Female"]);

        }
    }
}