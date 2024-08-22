using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyConnectionn
/// </summary>
public class MyConnectionn
{
    public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RMDD7OL;Initial Catalog=TestDB2;Integrated Security=True;TrustServerCertificate=True");

    public static void CheckConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }
}