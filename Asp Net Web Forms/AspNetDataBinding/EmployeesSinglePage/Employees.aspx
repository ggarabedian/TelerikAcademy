﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesSinglePage.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FormView ID="FormViewEmployees" runat="server" AllowPaging="true" OnPageIndexChanging="FormViewEmployees_OnPageIndexChanging">
            <ItemTemplate>
                <h3><%# Eval("FirstName") + " " + Eval("LastName")  %></h3>
                <table>
                    <tr>
                        <td>Job Title:</td>
                        <td><%#:Eval("Title") %></td>
                    </tr>
                    <tr>
                        <td>City</td>
                        <td><%#:Eval("City") %></td>
                    </tr>
                    <tr>
                        <td>Address</td>
                        <td><%#:Eval("Address") %></td>
                    </tr>
                    <tr>
                        <td>Notes</td>
                        <td><%#:Eval("Notes") %></td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:FormView>
    </form>
</body>
</html>
