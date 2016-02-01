<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionPage.aspx.cs" Inherits="Session.SessionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            2. Create a ASP.NET Web Form which appends the input of a text field when a button is clicked in the Session object and then prints it in a (asp:Label) control. Use List(string) to keep all the text lines entered in the page during the session lifetime.
        </p>
        <asp:TextBox ID="TextBoxInput" runat="server"/>
        <asp:Button ID="ButtonSaveInput" runat="server" Text="Save" OnClick="ButtonSaveInput_Click" />
        <br />
        <br />
        <asp:Label ID="LabelSessionType" runat="server"></asp:Label>
    </form>
</body>
</html>
