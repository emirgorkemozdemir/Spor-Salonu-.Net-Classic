using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        // Bağlantıyı kontrol ederek bağlantı kapalıysa bağlandım.
        MyConnection.CheckConnection();

        SqlCommand command_login = new SqlCommand("SELECT * FROM TableUser WHERE UserName=@pusername AND UserPassword=@ppass", MyConnection.connection);
        command_login.Parameters.AddWithValue("@pusername", tboxUsername.Text);
        command_login.Parameters.AddWithValue("@ppass", pboxPassword.Text);

        // Mantık olarak tek veri gelmesini veya hiç veri gelmemesini bekliyorsanız o zaman SqlDataReader 
        // kullanmanız gerekir.
        SqlDataReader data_reader = command_login.ExecuteReader();

        if (data_reader.HasRows == true)
        {
            // Session oturum demektir, web sitelerine giriş yaptığınızda
            // giriş yaptığınız id, kullanıcı adı veya online olma durumlarınız
            // kayıt edilir.

            Session["IsAdminOnline"] = true;
            data_reader.Close();
            Response.Redirect("Main.aspx");
        }
        else
        {
            data_reader.Close();
            Response.Write("Login failed");
        }

       
    }
}