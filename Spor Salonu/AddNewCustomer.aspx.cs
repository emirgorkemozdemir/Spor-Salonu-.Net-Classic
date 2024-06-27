using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddNewCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        MyConnection.CheckConnection();

        SqlCommand command_add = new SqlCommand("INSERT INTO TableCustomer (CustomerNameSurname,CustomerWeight,CustomerHeight,CustomerSubDate,CustomerPhone,CustomerBMI,CustomerFatPercent,CustomerMusclePercent) VALUES (@pname,@pweight,@pheight,@psub,@pphone,@pbmi,@pfat,@pmuscle)",MyConnection.connection);
    }
}