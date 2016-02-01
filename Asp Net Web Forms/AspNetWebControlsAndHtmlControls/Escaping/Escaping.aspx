<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Escaping.aspx.cs" Inherits="Escaping.Escaping" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Text to escape:
        <asp:TextBox ID="TextBoxUserInput" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="PrintEscapedInput_Click" />
        <br />
        <asp:TextBox ID="TextBoxEscapedInput" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="LabelEscapedInput" runat="server"></asp:Label>
    </form>
</body>
</html>
