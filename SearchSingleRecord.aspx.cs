using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

/*
 * AUTO POSTBACK = TRUE 
 */

public partial class SearchSingleRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataTable dt = DBLogic.FetchAllRecord();
            DropDownList1.DataSource = dt;
            DropDownList1.DataTextField = "userid";
            DropDownList1.DataValueField = "userid";
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = null;
        Label1.Text = DropDownList1.SelectedValue;
        try
        {
            con = DBLogic.GetConnection();

            String query = "select * from reg where userid = '" + DropDownList1.SelectedValue + "'";

            //create the SqlDataAdapter object
            SqlDataAdapter da = new SqlDataAdapter(query, con);

            //create the object Dataset
            DataSet ds = new DataSet();

            //Call the fill Method and pass the 
            //DataSet object
            da.Fill(ds);

            //get the no of tables dataset contains
            DataTable dt = ds.Tables[0];

            //bind the dataset table with the GridView
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        catch (Exception err)
        {
            Label1.Text = err.Message;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       
    }
}
