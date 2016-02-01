<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="ChatApp.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server" />

        <asp:Timer ID="Timer" Interval="500" runat="server" OnTick="Timer_Tick"></asp:Timer>
        <asp:UpdatePanel ID="UpdatePanelChat" runat="server" UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer"/>
            </Triggers>
            <ContentTemplate>
                <asp:ListView ID="ListViewMessages" runat="server">
                    <LayoutTemplate>
                        <div id="itemPlaceholder" runat="server">
                        </div>

                    </LayoutTemplate>
                    <ItemTemplate>
                        <strong><%#: Eval("Username") %>: </strong><%#: Eval("Content") %>
                        <br />
                    </ItemTemplate>
                </asp:ListView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <div>
            Message:
            <asp:TextBox ID="TextBoxMessage" runat="server"></asp:TextBox>
            Username:
            <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonSend" runat="server" Text="Save" OnClick="ButtonSend_Click" />
        </div>
    </form>
</body>
</html>
