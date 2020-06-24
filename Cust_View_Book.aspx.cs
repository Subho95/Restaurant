using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Cust_View_Book : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlConnection con = null;
        try
        {
            con = TbLogic.GetConnection();
            con.Open();
            String query = "select * from TBK where Book_ID = '" + TextBox1.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            int i = com.ExecuteNonQuery();
            if (i == 1)
            {
                Label2.Text = "Successfully done";
            }
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            GridView1.DataSource = dt;
            GridView1.DataBind();

        }
        catch (Exception err)
        {
            err.Message.ToString();
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