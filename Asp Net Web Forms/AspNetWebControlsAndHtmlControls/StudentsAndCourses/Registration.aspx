<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="StudentsAndCourses.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        First Name:
        <asp:TextBox ID="TextBoxFirstName" runat="server"></asp:TextBox>
        <br />
        Last Name:
        <asp:TextBox ID="TextBoxLastName" runat="server"></asp:TextBox>
        <br />
        Faculty Number:
        <asp:TextBox ID="TextBoxFacultyNumber" runat="server"></asp:TextBox>
        <br />
        School:
        <asp:DropDownList ID="DropdownSchool" runat="server">
            <asp:ListItem Value="1">Xavier's School for Gifted Youngsters</asp:ListItem>
            <asp:ListItem Value="2">Hogwarts School of Witchcraft and Wizardry</asp:ListItem>
            <asp:ListItem Value="3">Starfleet Academy</asp:ListItem>
            <asp:ListItem Value="4">The Jedi Praxeum</asp:ListItem>
        </asp:DropDownList>
        <br />
        Specialty:
        <asp:DropDownList ID="DropDownSpecialty" runat="server">
            <asp:ListItem Value="1">Freezing stuff</asp:ListItem>
            <asp:ListItem Value="2">Burning stuff</asp:ListItem>
            <asp:ListItem Value="3">Protection Spells Wizard</asp:ListItem>
            <asp:ListItem Value="4">Memory Charms Wizard</asp:ListItem>
            <asp:ListItem Value="5">DeathEater</asp:ListItem>
            <asp:ListItem Value="6">Explorer</asp:ListItem>
            <asp:ListItem Value="7">Jedi Knight</asp:ListItem>
            <asp:ListItem Value="8">Jedi Consular</asp:ListItem>
            <asp:ListItem Value="9">Sith</asp:ListItem>
        </asp:DropDownList>
        <br />
        Courses:
        <asp:ListBox ID="ListBoxCourses" runat="server" SelectionMode="Multiple">
            <asp:ListItem Value="1">C# and the Philosopher's Stone</asp:ListItem>
            <asp:ListItem Value="2">Algorithms and the Prisoner of Azkaban</asp:ListItem>
            <asp:ListItem Value="3">Javascript OOP - Where no one has gone before</asp:ListItem>
            <asp:ListItem Value="4">Single Page Apps - Seeing is believing</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Button ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click"/>
        <br />
        <br />
        <br />
        <strong>Student Information</strong>
        <div id="registeredUserInfo" runat="server">

        </div>
    </form>
</body>
</html>
