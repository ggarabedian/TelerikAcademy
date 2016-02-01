<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="TheLastTableOfEmployees.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formMain" runat="server">
        <div>
            <asp:GridView AutoGenerateColumns="false" runat="server" ID="EmployeesGridView"
                AllowPaging="true" AllowSorting="true" OnSorting="SortEmployees">
            <Columns>
                <asp:TemplateField SortExpression="FirstName" HeaderText="Full Name">
                    <ItemTemplate>
                        <%# Eval("FirstName") + " " + Eval("LastName")%>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField SortExpression="Country" DataField="Country" HeaderText="Country" />
                <asp:BoundField SortExpression="City" DataField="City" HeaderText="City" />
            </Columns>
            </asp:GridView>
            <asp:Button ID="btnPrev" Text="Prev" runat="server" OnClick="BtnPrev_Click" />
            <asp:Button ID="btnNext" Text="Next" runat="server" OnClick="BtnNext_Click" />

            <div id="emp-add-info">

            </div>
        </div>
    </form>
</body>
</html>
