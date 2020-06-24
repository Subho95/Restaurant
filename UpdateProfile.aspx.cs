using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class UpdateProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            String uid = (String)Session["uid"];

            RegInfo regobj = DBLogic.SearchSingleRecord(uid);

            txtuserid.Text = regobj.UserId;
            txtpass.Text = regobj.Pass;
            txtemail.Text = regobj.EmailId;
        }
        else
        {
            txtuserid.Text = "";
            txtpass.Text = "";
            txtemail.Text = "";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = null;
        try
        {
            con = DBLogic.GetConnection();

            con.Open();
            //build a query
            String query = "update reg set password = '"+txtpass.Text+"' ,emailid='"+txtemail.Text+"'  where userid = '" + txtuserid.Text + "'";
            SqlCommand com = new SqlCommand(query, con);

            //call the method of command object
            int result = com.ExecuteNonQuery();

            if (result > 0)
            {
                Label4.Text = "Record is UPDATED successfully";
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