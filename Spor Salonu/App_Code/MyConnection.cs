﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyConnection
/// </summary>
public class MyConnection
{
   
   public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-RMDD7OL;Initial Catalog=SportsCenterDB;Integrated Security=True;TrustServerCertificate=True");

   public static void CheckConnection()
   {
        // Bağlantı kapalıysa bağlantıyı açan bir metot oluşturduk. Bu metot sayesinde
        // işlem yaparken sürekli bağlantıyı açıp kapatmaktan kurtulduk.
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
   }
    
}