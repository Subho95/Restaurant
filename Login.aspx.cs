using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = null;
        
        try
        {
            con = DBLogic.GetConnection();
            con.Open();
            String query = "select * from reg where userid = '" + txtuserid.Text + "' and password = '"+txtpass.Text+"'";

            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                Session["uid"] = txtuserid.Text;
                Response.Redirect("AfterLogin.aspx");
            }
            else
            {
                Label4.Text = "INVALID UID OR PASS";
            }
            
        }
        catch (Exception err)
        {
            Label4.Text = err.Message;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
}