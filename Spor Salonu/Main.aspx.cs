using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Admin giriş yapılı durumda mı onu kontrol etmem lazım.
        // Çünkü bu sayfaya admin giriş yaptıysa erişim olmalı.
        if (Convert.ToBoolean(Session["IsAdminOnline"]) ==false)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {

        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        // Çıkış yaparken sessionların sıfırlanması lazım.
        Session.Clear();
        Response.Redirect("Login.aspx");
    }

    protected void btnNewCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("AddNewCustomer.aspx");
    }
}