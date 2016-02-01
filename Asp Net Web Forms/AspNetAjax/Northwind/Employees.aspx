<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Northwind.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridViewEmployees" runat="server"
            ItemType="Northwind.Data.Employee"
            SelectMethod="GridViewEmployees_GetData"
            DataKeyNames="EmployeeID"
            AutoGenerateColumns="false"
            OnSelectedIndexChanged="GridViewEmployees_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="EmployeeID" Visible="false" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="City" HeaderText="City" />
                <asp:BoundField DataField="Country" HeaderText="Country" />
                <asp:ButtonField Text="Select" CommandName="Select" ItemStyle-Width="30" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:Label ID="LabelTest" runat="server"></asp:Label>
        <asp:ScriptManager ID="ScriptManager" runat="server" />

        <asp:UpdateProgress ID="UpdateProgressDemo" runat="server">
            <ProgressTemplate>
                Updating ...
            </ProgressTemplate>
        </asp:UpdateProgress>

        <br />
        <asp:UpdatePanel ID="UpdatePanelOrders" runat="server">
            <Triggers>
                <asp:AsyncPostBackTrigger EventName="SelectedIndexChanged" ControlID="GridViewEmployees" />
            </Triggers>
            <ContentTemplate>
                <asp:GridView ID="GridViewOrders" runat="server"
                    Visible="false"
                    ItemType="Northwind.Data.Order">
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
</body>
</html>
