<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewCustomer.aspx.cs" Inherits="AddNewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button CssClass="btn btn-success" ID="btnAdd" runat="server" Text="Add Customer" OnClick="btnAdd_Click" />
    </form>
</body>
</html>
