<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowAllCustomers.aspx.cs" Inherits="ShowAllCustomers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Content/bootstrap.css" />
</head>
<body>

    <table class="table table-hover">
        <thead>
            <tr>
                <th>Customer ID</th>
                <th>Customer Name Surname</th>
                <th>Customer Subscription Date</th>
                <th>Show Customer Details</th>
                <th>Delete Customer</th>
            </tr>
        </thead>

        <tbody>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                    <tr class="table table-hover">
                        <td><%# Eval("CustomerID") %></td>
                        <td><%# Eval("CustomerNameSurname") %></td>
                        <td><%# Eval("CustomerSubDate") %></td>
                        <td><a class="btn btn-success" href="CustomerDetails.aspx?customerid=<%# Eval("CustomerID") %>">Get Detail</a></td>
                        <td><a class="btn btn-danger" href="DeleteCustomer.aspx?customerid=<%# Eval("CustomerID") %>">Delete</a></td>
                    </tr>
                </ItemTemplate>
            </asp:ListView>
        </tbody>
    </table>

</body>
</html>
