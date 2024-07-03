<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddNewCustomer.aspx.cs" Inherits="AddNewCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="tboxName" runat="server" placeholder="Enter customer name surname"></asp:TextBox>
        <asp:TextBox ID="tboxWeight" runat="server" placeholder="Enter customer weight"></asp:TextBox>
        <asp:TextBox ID="tboxHeight" runat="server" placeholder="Enter customer height"></asp:TextBox>
        <asp:TextBox ID="tboxPhone" runat="server" placeholder="Enter customer phone"></asp:TextBox>
        <asp:TextBox ID="tboxBMI" runat="server" placeholder="Enter customer BMI"></asp:TextBox>
        <asp:TextBox ID="tboxFat" runat="server" placeholder="Enter customer fat percentage"></asp:TextBox>
        <asp:TextBox ID="tboxMuscle" runat="server" placeholder="Enter customer muscle percentage"></asp:TextBox>
        <asp:Button CssClass="btn btn-success" ID="btnAdd" runat="server" Text="Add Customer" OnClick="btnAdd_Click" />
    </form>
</body>
</html>
