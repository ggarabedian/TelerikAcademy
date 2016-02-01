<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="EmployeesListView.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListView ID="ListViewEmployees" runat="server" ItemType="EmployeesListView.Data.Employee">
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceholder" runat="server"></asp:PlaceHolder>
            </LayoutTemplate>

            <ItemSeparatorTemplate>
                <hr />
            </ItemSeparatorTemplate>

            <ItemTemplate>
                <div runat="server">
                    <h3><%#: Item.FirstName + " " + Item.LastName  + ", " + Item.Title %></h3>
                    <h4><%#: Item.Address + " " + Item.City %></h4>
                    <p><%#: Item.Notes %></p>
                </div>
            </ItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
