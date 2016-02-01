<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomNumberGenerator.aspx.cs" Inherits="Random.RandomNumberGenerator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formMain" runat="server">
        <div>Using HTML Server Controls</div>
        <br />
        Min number: <input id="TextBoxMinNumber" value="10" type="text" runat="server" />
        <br />
        Max number: <input id="TextBoxMaxNumber" value="20" type="text" runat="server" />
        <br />
        <input id="GenerateRandomHtml" type="button"
            runat="server" value="Submit"
            onserverclick="GenerateRandomHtml_Click" />
        <br />
        <label id="ResultHtml" runat="server"></label>
        <br />
        <br />
        <br />
        <div>Using Web Server Controls</div>
        <br />
        Min number: <asp:TextBox ID="TbMinNumber" value="10" type="text" runat="server" />
        <br />
        Max number: <asp:TextBox ID="TbMaxNumber" value="20" type="text" runat="server" />
        <br />
        <asp:Button ID="GenerateRandomWeb" runat="server" 
            Text="Submit" OnClick="GenerateRandomWeb_Click" />
        <br />
        <asp:Label id="ResultWeb" runat="server"></asp:Label>
    </form>
</body>
</html>
