using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerDetails : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Diğer sayfadan gönderilen id değerine göre tek bir kullanıcıyı almam 
        // gerekiyor.

        if (Convert.ToBoolean(Session["IsAdminOnline"]) == false)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            int selected_id = Convert.ToInt32(Request.QueryString["customerid"]);
            // Bağlantıyı kontrol ettik
            MyConnection.CheckConnection();

            // Verileri almak için bir sql komutu oluşturuyorum.
            SqlCommand command_list = new SqlCommand("SELECT * FROM TableCustomer WHERE CustomerID=@pid", MyConnection.connection);
            command_list.Parameters.AddWithValue("@pid",selected_id);

            // Komutu okuyucuda okuduk.
            SqlDataReader reader = command_list.ExecuteReader();

            // Veri kaynağı olarak okuyucuyu verdik.
            ListView1.DataSource = reader;

            // Veriyi çek metodu.
            ListView1.DataBind();

            reader.Close();

        }
    }
}