<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet"  href="Content/bootstrap.css"/>
</head>
<body>
    <form id="form1" runat="server" class="form-control">
        <asp:TextBox ID="tboxUsername" CssClass="form-control"  runat="server"></asp:TextBox>
        
        <asp:TextBox ID="pboxPassword" CssClass="form-control" runat="server"></asp:TextBox>

        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-danger" OnClick="btnLogin_Click"/>

         <%--// Html ögesi kullanırsanız runat=server demeyi unutmayın--%> 
         <%--<input runat="server" />--%>
    </form>
</body>
</html>
