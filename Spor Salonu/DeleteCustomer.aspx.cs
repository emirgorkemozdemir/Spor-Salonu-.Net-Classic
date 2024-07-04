using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToBoolean(Session["IsAdminOnline"]) == false)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            int selected_id = Convert.ToInt32(Request.QueryString["customerid"]);
            MyConnection.CheckConnection();

            SqlCommand command_delete = new SqlCommand("DELETE FROM TableCustomer WHERE CustomerID=@pid",MyConnection.connection);
            command_delete.Parameters.AddWithValue("@pid",selected_id);
            command_delete.ExecuteNonQuery();
            Response.Redirect("ShowAllCustomers.aspx");
        }
    }
}