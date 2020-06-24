using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class CTB : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            TbInfo tbji = new TbInfo();
            tbji.Tableno = txttb.Text;
            tbji.Date = txtd.Text;
            tbji.Sessions = Ss.SelectedItem.Text;
            if ((tbji.Sessions).Equals("Lunch"))
            {
                SqlConnection con = null;
                con = TbLogic.GetConnection();
                con.Open();
                String query = "select * from TBL where Date = '" + txtd.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    tbji.Availability = dr[1].ToString();
                    if (Int32.Parse(txttb.Text) <= Int32.Parse(tbji.Availability))
                    {
                        SqlConnection con1 = null;
                        con1 = TbLogic.GetConnection();
                        con1.Open();
                        String query1 = "Update TBL set Availability = '" + (Int32.Parse(tbji.Availability) - Int32.Parse(tbji.Tableno)) + "' where Date='" + tbji.Date + "'";
                        SqlCommand com1 = new SqlCommand(query1, con1);
                        //SqlDataReader d1r = com1.ExecuteReader();
                        int i = com1.ExecuteNonQuery();
                        if (i == 1)
                        {
                            Lbl.Text = "Booked for Lunch";
                        }
                        else
                        {
                            Lbl.Text = "Not Booked";
                        }
                        con1.Close();
                    }
                    else
                    {
                        Lbl.Text = "Not Availble";
                    }
                    //con.Close();
                }
                else
                {
                    if (Int32.Parse(tbji.Tableno) <= 10)
                    {
                        SqlConnection con1 = null;
                        con1 = TbLogic.GetConnection();
                        con1.Open();
                        String query1 = "insert into TBL" + "(Date,Availability) values" + "('" + txtd.Text + "','" + (10 - Int32.Parse(txttb.Text)) + "')";
                        SqlCommand com1 = new SqlCommand(query1, con1);
                        int i = com1.ExecuteNonQuery();
                        if (i == 1)
                        {
                            Lbl.Text = "Inserted To Lunch";
                        }
                        else { Lbl.Text = "Try Again"; }
                        //con1.Close();
                    } 
                    else
                    {
                        Lbl.Text = "U can have max of 10";
                    }
                }
            }
            else
            {
                SqlConnection con = null;
                con = TbLogic.GetConnection();

                con.Open();
                String query = "select * from TBD where Date = '" + txtd.Text + "'";
                SqlCommand com = new SqlCommand(query, con);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.Read())
                {
                    tbji.Availability = dr[1].ToString();
                    if (Int32.Parse(txttb.Text) <= Int32.Parse(tbji.Availability))
                    {
                        SqlConnection con1 = null;
                        con1 = TbLogic.GetConnection();
                        con1.Open();
                        String query1 = "Update TBD set Availability = '" + (Int32.Parse(tbji.Availability) - Int32.Parse(txttb.Text)) + "' where Date='" + txtd.Text + "'";
                        SqlCommand com1 = new SqlCommand(query1, con1);
                        //SqlDataReader d1r = com1.ExecuteReader();
                        int i = com1.ExecuteNonQuery();
                        if (i == 1)
                        {
                            Lbl.Text = "Booked for Dinner";
                        }
                        else { Lbl.Text = "Try Again"; }
                        con1.Close();
                    }
                    else
                    {
                        Lbl.Text = "Not Availble";
                    }
                }
                else
                {
                    if (Int32.Parse(tbji.Tableno) <= 10)
                    {
                        SqlConnection con1 = null;
                        con1 = TbLogic.GetConnection();
                        con1.Open();
                        String query1 = "insert into TBD" + "(Date,Availability) values" + "('" + txtd.Text + "','" + (10 - Int32.Parse(tbji.Tableno)) + "')";
                        SqlCommand com1 = new SqlCommand(query1, con1);
                        int i = com1.ExecuteNonQuery();
                        if (i == 1)
                        {
                            Lbl.Text = "Inserted To Dinner";
                        }
                        else { Lbl.Text = "Try Again"; }
                        con1.Close();
                    }
                    else
                    {
                        Lbl.Text = "U can have max of 10";
                    }
                }
                con.Close();
            }
        }
        catch (Exception err)
        {
            Lbl.Text = err.Message.ToString();
        }
        Session["Session"] = Ss.SelectedItem.Text;
        Session["Date"] = txtd.Text;
        Session["NoTable"] = txttb.Text;
    }

    protected void avail2_Click(object sender, EventArgs e)
    {

         SqlConnection con = null;
         try
         {
             con = TbLogic.GetConnection();

             con.Open();
             TbInfo tbj = new TbInfo();
             tbj.Tableno = txttb.Text;
             tbj.Date = txtd.Text;
             tbj.Sessions = Ss.SelectedItem.Text;

             if ((tbj.Sessions).Equals("Lunch"))
             {
                 String query = "select * from TBL where Date = '" + txtd.Text + "'";
                 SqlCommand com = new SqlCommand(query, con);
                 SqlDataReader dr = com.ExecuteReader();
                 if (dr.Read())
                 {
                     tbj.Availability = dr[1].ToString();
                     if (Int32.Parse(txttb.Text) <= Int32.Parse(tbj.Availability))
                     {
                         Lbl.Text = "Availble " + dr["Availability"].ToString();

                     }
                     else
                     {
                         Lbl.Text = "Not Availble";
                     }
                 }
                 else
                 {
                     if (Int32.Parse(txttb.Text) <= 10)
                     {
                         Lbl.Text = "Full Available";
                     }
                     else
                     {
                         Lbl.Text = "U can have max of 10";
                     }
                 }
             }
             else
             {
                 String query = "select * from TBD where Date = '" + txtd.Text + "'";
                 SqlCommand com = new SqlCommand(query, con);
                 SqlDataReader dr = com.ExecuteReader();
                 if (dr.Read())
                 {
                     tbj.Availability = dr[1].ToString();
                     if (Int32.Parse(txttb.Text) <= Int32.Parse(tbj.Availability))
                     {
                         Lbl.Text = "Availble " + dr["Availability"].ToString();

                     }
                     else
                     {
                         Lbl.Text = "Not Availble";
                     }
                 }
                 else
                 {
                     if (Int32.Parse(txttb.Text) <= 10)
                     {
                         Lbl.Text = "Full Available";
                     }
                     else
                     {
                         Lbl.Text = "U can have max of 10";
                     }
                 }

             }
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Random r = new Random();
        int bk_id = r.Next(100, 10000);
        SqlConnection con = null;
        try
        {
            con = TbLogic.GetConnection();

            con.Open();
            TbInfo tbjj = new TbInfo();
            tbjj.Tableno = txttb.Text;
            tbjj.Date = txtd.Text;
            tbjj.Sessions = Ss.SelectedItem.Text;
            String query = "insert into TBK" + "(Book_ID,Name,Mobile,NoTable,Session,Date) values" + "('"+ bk_id +"','" + Session["Name"] + "','" + Session["Mobile"] + "','" + Session["NoTable"] + "','" + Session["Session"] + "','" + Session["Date"] + "')";
            SqlCommand com = new SqlCommand(query, con);
            int i = com.ExecuteNonQuery();
            if (i == 1)
            {
                Session["Book_ID"] = bk_id;
                Response.Redirect("A_T_B.aspx");
            }
            else { Lbl.Text = "Try Again Plz"; }
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

