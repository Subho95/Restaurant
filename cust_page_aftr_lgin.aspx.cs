using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurant
{
    public partial class admnpage_aftr_lgin : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = "Sayan";  
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("onlineorder.aspx");
        }
    }
}