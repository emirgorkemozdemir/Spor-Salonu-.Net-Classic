using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ShowAllCustomers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Bağlantıyı kontrol ettik
        MyConnection.CheckConnection();

        // Verileri almak için bir sql komutu oluşturuyorum.
        SqlCommand command_list = new SqlCommand("SELECT CustomerID,CustomerNameSurname,CustomerSubDate FROM TableCustomer",MyConnection.connection);

        // Komutu okuyucuda okuduk.
        SqlDataReader reader = command_list.ExecuteReader();

        // Veri kaynağı olarak okuyucuyu verdik.
        DataList1.DataSource = reader;

        // Veriyi çek metodu.
        DataList1.DataBind();

        reader.Close();
    }
}