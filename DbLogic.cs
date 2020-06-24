using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DbLogic
/// </summary>
public class DbLogic
{
	public DbLogic()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static SqlConnection GetConnection()
    {
        String connectionString = @"Data Source=.\sqlexpress;Initial Catalog=DotNet;Integrated Security=True;Pooling=False";

        SqlConnection con = new SqlConnection(connectionString);

        return con;
    }
}