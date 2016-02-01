<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarSearching.aspx.cs" Inherits="CarSearching.CarSearching" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Producer: 
        <asp:DropDownList ID="DropDownListProducers" runat="server" 
            AutoPostBack="true" 
            OnSelectedIndexChanged="DropDownListProducers_Changed">
        </asp:DropDownList>
        <br />
        Model: 
        <asp:DropDownList ID="DropDownListModels" runat="server" 
            AutoPostBack="true" 
            OnSelectedIndexChanged="DropDownListModels_Changed">
        </asp:DropDownList>

        <asp:CheckBoxList ID="CheckBoxListExtras" runat="server" AutoPostBack="true">
        </asp:CheckBoxList>

        <asp:RadioButtonList ID="RadioButtonListEngines" runat="server" AutoPostBack="true" RepeatDirection="Horizontal">
        </asp:RadioButtonList>

        <asp:Button ID="ButtonSearch" runat="server" 
            OnClick ="ButtonSearch_Click" 
            Text="Search"/>
        <br />
        <br />
        <br />

        <asp:Literal ID="LiteralCarDetails" runat="server" Mode="Encode">
        </asp:Literal>
    </form>
</body>
</html>
