<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuTreeView.aspx.cs" Inherits="XmlTreeView.MenuTreeView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:XmlDataSource ID="XmlDataSourceMenu" runat="server" DataFile="~/Menu.xml"></asp:XmlDataSource>
        <asp:TreeView ID="TreeViewMenu" runat="server" 
            DataSourceID="XmlDataSourceMenu"
            ShowCheckBoxes="Leaf" 
            ImageSet="Arrows">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="breakfast_menu" Text="breakfast_menu" />
            </DataBindings>
            <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
        </asp:TreeView>
        <br />

        <asp:Button ID="ShowResult" runat="server" Text="Show Result" OnClick="ShowResult_Click" />
        <asp:Literal ID="CheckedNodeInfo" runat="server" Mode="Encode">
        </asp:Literal>
    </form>
</body>
</html>
