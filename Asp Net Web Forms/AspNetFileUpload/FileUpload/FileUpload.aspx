<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUpload.aspx.cs" Inherits="FileUpload.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FileUpload ID="FileUploadSelect" runat="server" />
        <asp:Button ID="UploadButton" runat="server" Text="Upload" OnClick="UploadButton_Click" />
        <br />
        <asp:Literal ID="LiteralMessage" runat="server">
        </asp:Literal>
        <asp:Repeater ID="RepeaterZipContent" runat="server"
            ItemType="System.string">
            <ItemTemplate>
                <p>
                    <%# Item %>
                </p>
            </ItemTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
