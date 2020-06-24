using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Cust_LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SignInfo sj = new SignInfo();
        SqlConnection con = null;

        try
        {
            con = DbLogic.GetConnection();
            con.Open();
            String query = "select * from reg where Mobile = '" + txtm.Text + "' and Password = '" + txtp.Text + "'";

            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader dr = com.ExecuteReader();

            if (dr.Read())
            {
                Session["Mobile"] = txtm.Text;
                Session["Name"] = dr[0].ToString();
                Session["Address"] = dr[3].ToString();
                Response.Redirect("Customer_After_Login.aspx");
                //Lbl.Text = "Successfully Logged";
            }
            else
            {
                Label3.Text = "INVALID MOBILE OR PASS";
            }

        }
        catch (Exception err)
        {
            Label3.Text = err.Message;
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