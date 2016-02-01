<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="CookiesWithTwoPages.FirstPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            3. Create two pages that exchange user data with cookies. The first page is a login page. The second one redirects to the first one if the expected cookie is missing. The cookie must expire in 1 minute.
        </p>
        <asp:Button ID="ButtonLogIn" runat="server" Text="Log In" OnClick="ButtonLogIn_Click" />
        <br />
        <br />
        <asp:Button ID="ButtonSecondPage" runat="server" Text="Go To Second Page" OnClick="ButtonSecondPage_Click" />
        <br />
        <br />
        <asp:Label ID="LabelMessage" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <p>
            4. Implement a graphical Web counter. It should display as JPEG image the total number of visitors of the requested .aspx page since the start of the Web application. Keep the number of visitors in the Application object. What happens when the Web server is stopped?
            <br />
            <br />
            Unique visits: <asp:Label ID="LabelCounter" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
