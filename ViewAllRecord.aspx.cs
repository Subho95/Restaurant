using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class ViewAllRecord : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = DBLogic.FetchAllRecord();
        GridView1.DataSource = dt;
        GridView1.DataBind();

      /*  SqlConnection con = null;
        try
        {
            con = DBLogic.GetConnection();

            String query = "select * from reg ";

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
        }*/
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}