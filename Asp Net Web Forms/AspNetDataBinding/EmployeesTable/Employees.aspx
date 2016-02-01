<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesTable.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="RepeaterEmployees" runat="server">
            <HeaderTemplate>
                <table border="1">
                    <tr>
                        <th>Job Title:</th>
                        <th>City</th>
                        <th>Address</th>
                        <th>Notes</th>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><%#:Eval("Title") %></td>
                    <td><%#:Eval("City") %></td>
                    <td><%#:Eval("Address") %></td>
                    <td><%#:Eval("Notes") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
