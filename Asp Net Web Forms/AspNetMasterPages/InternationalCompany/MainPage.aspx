<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="InternationalCompany.MainPage" %>


<asp:Content ID="ChooseLocalizationContent" runat="server"
    ContentPlaceHolderID="ContentPlaceHolderMainContent">
    <h1>Welcome to our international company web site!</h1>
    <asp:HyperLink runat="server" NavigateUrl="~/English/Home.aspx" 
        Text="English" CssClass="users-icon"/>
    <asp:HyperLink runat="server" NavigateUrl="~/Bulgarian/Home.aspx"
         Text="Български" CssClass="administrators-icon"/>
</asp:Content>