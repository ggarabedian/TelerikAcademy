<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesTwoPages.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:GridView ID="GridViewEmployees" runat="server">
        <Columns>
            <asp:HyperLinkField DataNavigateUrlFields="Id" DataNavigateUrlFormatString="EmployeeDetails.aspx?id={0}" DataTextField="FullName" HeaderText="Full Name"/>
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
