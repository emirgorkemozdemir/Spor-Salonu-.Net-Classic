<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button CssClass="btn btn-danger" ID="btnNewCustomer" runat="server" Text="Add New Customer" OnClick="btnNewCustomer_Click" />
        <asp:Button CssClass="btn btn-danger" ID="btnShowAllCustomer" runat="server" Text="Show All Customer" OnClick="btnShowAllCustomer_Click" />
        <asp:Button CssClass="btn btn-danger" ID="btnStats" runat="server" Text="My Stats" />
        <asp:Button CssClass="btn btn-danger" ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
    </form>
</body>
</html>

