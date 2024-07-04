<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDetails.aspx.cs" Inherits="CustomerDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:ListView ID="ListView1" runat="server">
        <ItemTemplate>
            <div>Customer Name Surname : <%# Eval("CustomerNameSurname") %></div>
            <div>Customer Weight : <%# Eval("CustomerWeight") %></div>
            <div>Customer Height : <%# Eval("CustomerHeight") %></div>
            <div>Customer Subscription Date : <%# Eval("CustomerSubDate") %></div>
            <div>Customer Phone: <%# Eval("CustomerPhone") %></div>
            <div>Customer BMI: <%# Eval("CustomerBMI") %></div>
            <div>Customer Fat Percentage: <%# Eval("CustomerFatPercent") %></div>
            <div>Customer Muscle Percentage: <%# Eval("CustomerMusclePercent") %></div>
        </ItemTemplate>
    </asp:ListView>
</body>
</html>
