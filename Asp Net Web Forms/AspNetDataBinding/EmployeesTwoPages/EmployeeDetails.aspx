<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDetails.aspx.cs" Inherits="EmployeesTwoPages.EmployeeDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DetailsView ID="DetailsViewEmployee" runat="server">
        </asp:DetailsView>
        <asp:HyperLink NavigateUrl="~/Employees.aspx" Text="Back" runat="server"></asp:HyperLink>
    </form>
</body>
</html>
