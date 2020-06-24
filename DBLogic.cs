using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

using System.Data;
/// <summary>
/// Summary description for DBLogic
/// </summary>
public class DBLogic
{
	public DBLogic()
	{
	}

    public static SqlConnection GetConnection()
    { 
      String connectionString= @"Data Source=.\sqlexpress;Initial Catalog=DotNet;Integrated Security=True;Pooling=False";

      SqlConnection con = new SqlConnection(connectionString);

      return con;
    }

    public static DataTable FetchAllRecord()
    {
        SqlConnection con = null;
        DataTable dt = null;

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
            dt = ds.Tables[0];
                  
        }
        catch (Exception err)
        {
            //Label1.Text = err.Message;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
            
        }
        return dt;
    }

    public static RegInfo SearchSingleRecord(String uid)
    {
        SqlConnection con = null;
        RegInfo regobj = new RegInfo();
        try
        {
            con = DBLogic.GetConnection();
            con.Open();
            String query = "select * from reg where userid = '" + uid + "'";

            SqlCommand com = new SqlCommand(query, con);

            SqlDataReader dr = com.ExecuteReader();

            dr.Read();

            regobj.UserId = dr[0].ToString();
            regobj.Pass = dr[1].ToString();
            regobj.EmailId = dr[2].ToString();

        }
        catch (Exception err)
        {
            //Label1.Text = err.Message;
        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }

        }
        return regobj;
    }



}