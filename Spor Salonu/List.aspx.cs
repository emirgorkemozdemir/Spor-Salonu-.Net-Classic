using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        MyConnectionn.CheckConnection();
        SqlCommand cmd = new SqlCommand("SELECT * FROM TableProduct", MyConnectionn.connection);

        SqlDataReader dataReader = cmd.ExecuteReader();

        ListView1.DataSource = dataReader;

        ListView1.DataBind();

        dataReader.Close();
    }

    protected void tboxFilter_TextChanged(object sender, EventArgs e)
    {
        MyConnectionn.CheckConnection();

        SqlCommand cmd = new SqlCommand("SELECT * FROM TableProduct WHERE ProductName LIKE @pname", MyConnectionn.connection);
        cmd.Parameters.AddWithValue("@pname","%"+tboxFilter.Text+"%");

        SqlDataReader dataReader = cmd.ExecuteReader();

        ListView1.DataSource = dataReader;

        ListView1.DataBind();

        dataReader.Close();
    }
}