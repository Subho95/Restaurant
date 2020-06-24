using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Delete : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = null;
        try
        {
            con = DBLogic.FetchAllRecord();

            con.Open();
            //build a query
            String query = "delete from reg where userid ='" + txtuserid.Text + "'";
            SqlCommand com = new SqlCommand(query, con);

            //call the method of command object
            int result = com.ExecuteNonQuery();

            if (result > 0)
            {
                Label2.Text = "Record DELETED successfully";
            }
            else
            {
                Label2.Text = "NO Record FOUND";
            }
        }
        catch (Exception err)
        {
            Label2.Text = err.Message;
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