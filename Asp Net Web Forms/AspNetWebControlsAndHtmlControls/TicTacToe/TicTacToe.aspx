<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicTacToe.aspx.cs" Inherits="TicTacToe.TicTacToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="ResetButton" Text="Reset" runat="server" OnClick="ResetButton_Click"/>
        <br />
        <br />
        <asp:ImageButton ID="Field1" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <asp:ImageButton ID="Field2" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <asp:ImageButton ID="Field3" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <br />
        <asp:ImageButton ID="Field4" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <asp:ImageButton ID="Field5" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <asp:ImageButton ID="Field6" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <br />
        <asp:ImageButton ID="Field7" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <asp:ImageButton ID="Field8" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <asp:ImageButton ID="Field9" ImageUrl="images/EmptyField.png" runat="server" OnClick="Field_Click"/>
        <br />
        <asp:Label ID="LabelMessage" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
