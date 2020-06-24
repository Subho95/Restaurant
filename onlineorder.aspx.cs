using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace restaurant
{
    public partial class onlineorder : System.Web.UI.Page
    {
        int qprice;
        public static int totprice;
        public static int price()
        {
             totprice = 0;
            return totprice;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label7.Text = "welcome";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("cust_after_chkout.aspx");
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(TextBox1.Text+" "+ DropDownList1.SelectedItem.Text+" "+qprice);
            totprice = totprice + qprice;
            Label5.Text = totprice.ToString();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            qprice = Int32.Parse(TextBox1.Text) * Int32.Parse(DropDownList1.SelectedValue);
            Label2.Text = qprice.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string s=ListBox1.SelectedItem.ToString();
            string[] a=s.Split(' ');
            string dct = a[2];
            int deduct = Int32.Parse(dct);
            totprice = totprice - deduct;
            Label5.Text = totprice.ToString();
            ListBox1.Items.Remove(ListBox1.SelectedItem.ToString());
        }
    }
}