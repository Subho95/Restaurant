using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;


/// <summary>
/// Summary description for TbInfo
/// </summary>
public class TbInfo
{
	public TbInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static int a
    {
        get;
        set;
    }
    public String Tableno
    {
        get;
        set;
    }
    public String Date
    {
        get;
        set;
    }
    public String Sessions
    {
        get;
        set;
    }
    public String Avail
    {
        get;
        set;
    }
    public String Availability
    {
        get;
        set;
    }
}