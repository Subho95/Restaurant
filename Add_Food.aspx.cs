﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Add_Food : System.Web.UI.Page
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
            String query = "insert into Veg" + "(ID,Name,Price) values" + "('" + foodid.Text + "','" + foodname.Text + "','" + foodprice.Text + "')";
            SqlCommand com = new SqlCommand(query, con);
            int i = com.ExecuteNonQuery();
            if (i == 1)
            {
                Response.Redirect("View_Menu.aspx");
                //Lbl.Text = "Added Successfully";
            }
            else { Lbl.Text = "Try Again"; }
        }
        catch (Exception err)
        {
            Lbl.Text=err.Message.ToString();
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