<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Table ID="TableCalculator" runat="server" BorderWidth="3">
            <asp:TableHeaderRow>
                <asp:TableCell ColumnSpan="4">
                    <asp:TextBox ID="TextBoxScreen" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableHeaderRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button1" Text="1" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button2" Text="2" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button3" Text="3" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="ButtonAddition" Text="+" runat="server" Width="40" OnClick="OperationButton_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button4" Text="4" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button5" Text="5" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button6" Text="6" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="ButtonSubtraction" Text="-" runat="server" Width="40" OnClick="OperationButton_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="Button7" Text="7" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button8" Text="8" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button9" Text="9" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="ButtonMultiplication" Text="*" runat="server" Width="40" OnClick="OperationButton_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="ButtonClear" Text="Clear" runat="server" Width="40" OnClick="ButtonClear_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="Button0" Text="0" runat="server" Width="40" OnClick="NumericButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="ButtonDivision" Text="/" runat="server" Width="40" OnClick="OperationButton_Click"/>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="ButtonSquareRoot" Text="√" runat="server" Width="40" OnClick="SquareRootButton_Click"/>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow>
                <asp:TableCell HorizontalAlign="Center" ColumnSpan="4">
                    <asp:Button ID="ButtonEquals" Text="=" runat="server" Width="120" OnClick="OperationButton_Click"/>
                </asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
