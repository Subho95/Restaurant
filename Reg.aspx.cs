using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Reg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //txtuserid.Text = "";
        //txtpass.Text = "";
        //txtemail.Text = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = null;
        try
        {
            con = DBLogic.GetConnection();

            con.Open();
            //build a query
            String query = "insert into reg values ('" + txtuserid.Text + "','" + txtpass.Text + "','" + txtemail.Text + "')";
            SqlCommand com = new SqlCommand(query, con);

            //call the method of command object
            int result = com.ExecuteNonQuery();

            if (result == 1)
            {
                Label4.Text = "Record is Inserted successfully";
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