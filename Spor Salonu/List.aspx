<%@ Page Language="C#" AutoEventWireup="true" CodeFile="List.aspx.cs" Inherits="List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css" />
</head>
<body>
    <form runat="server">
        <asp:Label ID="Label1" runat="server" Text="Ürünü İsme Göre Filtrele"></asp:Label>
        <asp:TextBox ID="tboxFilter" runat="server" OnTextChanged="tboxFilter_TextChanged"></asp:TextBox>
        <br />
    </form>


    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <div><%# Eval("ProductName") %>  </div>
            <div><%# Eval("ProductPrice") %>  </div>
            <a class="btn btn-success">Ürünü Detaylı Görüntüle</a>
        </ItemTemplate>
    </asp:ListView>
</body>
</html>
