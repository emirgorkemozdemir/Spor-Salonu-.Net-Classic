<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowAllCustomers.aspx.cs" Inherits="ShowAllCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css" />
</head>
<body>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>

            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Name Surname</th>
                        <th>Subscription Date</th>
                    </tr>
                </thead>

                <tbody>
                    <tr>
                        <td><%# Eval("CustomerID") %></td>
                        <td><%# Eval("CustomerNameSurname") %></td>
                        <td><%# Eval("CustomerSubDate") %></td>
                    </tr>
                </tbody>
            </table>

        </ItemTemplate>
    </asp:DataList>
</body>
</html>
