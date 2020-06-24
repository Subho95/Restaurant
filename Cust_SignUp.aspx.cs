using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Cust_SignUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = null;
        try
        {
            con = DbLogic.GetConnection();

            con.Open();
            String query = "insert into reg values ('" + txtname.Text + "','" + txtmail.Text + "','" + txtmob.Text + "','" + txtadd.Text + "','" + txtpass.Text + "','" + prf.SelectedItem.Text + "')";
            SqlCommand com = new SqlCommand(query, con);
            int result = com.ExecuteNonQuery();
            if (result == 1)
            {
                Lbl.Text = "Record is Inserted successfully";
                Response.Redirect("Cust_LogIn.aspx");
            }
        }
        catch (Exception err)
        {
            Lbl.Text = err.Message.ToString();
            txtname.Text = "";
            txtmail.Text = "";
            txtmob.Text = "";
            txtadd.Text = "";
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