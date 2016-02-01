<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Earth.aspx.cs" Inherits="Countries.Earth" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <ef:EntityDataSource ID="EfEntityDataSourceContinents" runat="server"
            OnContextCreating="EfEntityDataSource_ContextCreating"
            EntitySetName="Continents"
            EnableFlattening="False">
        </ef:EntityDataSource>

        <asp:ListBox ID="ListBoxContinents"
            runat="server"
            AutoPostBack="True"
            DataSourceID="EfEntityDataSourceContinents"
            DataTextField="Name"
            DataValueField="Id" Height="142px" Width="82px"></asp:ListBox>

        <hr />

        <ef:EntityDataSource ID="EfEntityDataSourceCountries"
            runat="server"
            OnContextCreating="EfEntityDataSource_ContextCreating"
            EnableFlattening="False"
            EnableInsert="True" EnableDelete="True" EnableUpdate="True"
            EntitySetName="Countries"
            Include="Continent"
            Where="it.ContinentId=@ContinentId" EntityTypeFilter="Country">
            <WhereParameters>
                <asp:ControlParameter Name="ContinentId" Type="Int32"
                    ControlID="ListBoxContinents" />
            </WhereParameters>
        </ef:EntityDataSource>

        <asp:GridView ID="GridViewCountries" runat="server"
            DataSourceID="EfEntityDataSourceCountries" AutoGenerateColumns="False"
            DataKeyNames="Id" AllowPaging="True" AllowSorting="True" PageSize="2" ItemType="Countries.Data.Country">
            <%--ShowFooter="true"--%>
            <Columns>
                <asp:CommandField ShowSelectButton="True" ShowEditButton="True" ShowDeleteButton="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                <asp:BoundField DataField="Population" HeaderText="Population" SortExpression="Population" ReadOnly="true" />
                <asp:TemplateField HeaderText="Country Flag">
                    <ItemTemplate>
                        <img src="<%#:Item.Flag !=null?"data:image/png;base64,"+Convert.ToBase64String(Item.Flag):""%> "
                            alt="<%#:Item.Flag !=null?(Item.Name):"No Image" %>" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:FileUpload ID="FileUploadEditFlag" filebytes='<%#: Bind("Flag") %>' runat="server" />
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <asp:ListView runat="server" ID="ListViewInsertCountryForm"
            DataSourceID="EfEntityDataSourceCountries"
            ItemType="Countries.Data.Country"
            DataKeyNames="Id"
            OnItemInserted="ListViewInsertCountryForm_ItemInserted"
            InsertItemPosition="LastItem"
            OnItemCanceling="ListViewInsertCountryForm_ItemCanceling">

            <LayoutTemplate>
                <div runat="server" id="itemPlaceholder" />
                <asp:Button ID="ButtonInsertCountry" runat="server" Text="Insert Country" OnClick="ButtonInsertCountry_Click" Visible="true" />
            </LayoutTemplate>

            <EmptyDataTemplate>
                <div>No data was returned.</div>
            </EmptyDataTemplate>

            <ItemTemplate>
            </ItemTemplate>

            <InsertItemTemplate>
                <div class="insert-item">
                    Name:
                    <asp:TextBox ID="TextBoxCountryName" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Language:
                    <asp:TextBox ID="TextBoxLanguage" runat="server" Text='<%# Bind("Language") %>' />
                    <br />
                    Population:
                    <asp:TextBox ID="TextBoxPopulation" runat="server" Text='<%# Bind("Population") %>' />
                    <br />
                    Continent:
                    <asp:DropDownList ID="DropDownListContinents" runat="server" DataSourceID="EfEntityDataSourceContinents"
                        DataValueField="Id"
                        DataTextField="Name"
                        SelectedValue="<%#: BindItem.ContinentId %>"
                        AutoPostBack="true" />
                    <br />
                    Insert Country Flag: 
                    <asp:FileUpload ID="FileUploadFlag" filebytes='<%#: Bind("Flag") %>' runat="server" />
                    <br />
                    <asp:Button ID="ButtonInsert" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button ID="ButtonCancel" runat="server" CommandName="Cancel" Text="Cancel" />
                </div>
            </InsertItemTemplate>
        </asp:ListView>

        <ef:EntityDataSource ID="EfEntityDataSourceTowns" runat="server"
            OnContextCreating="EfEntityDataSource_ContextCreating"
            EntitySetName="Towns"
            EnableFlattening="False"
            EnableInsert="True" EnableDelete="True" EnableUpdate="True"
            Include="Country"
            Where="it.CountryId=@CountryId" EntityTypeFilter="Town">
            <WhereParameters>
                <asp:ControlParameter Name="CountryId" Type="Int32" ControlID="GridViewCountries" />
            </WhereParameters>
        </ef:EntityDataSource>

        <hr />

        <asp:ListView ID="ListViewTowns"
            runat="server"
            DataSourceID="EfEntityDataSourceTowns"
            ItemType="Countries.Data.Town"
            DataKeyNames="Id"
            InsertItemPosition="None" OnItemCanceling="ListViewTowns_ItemCanceling">

            <EditItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                    <td>
                        <asp:TextBox ID="NameTextBox" runat="server" Text='<%# Bind("Name") %>' />
                    </td>
                    <td>
                        <asp:TextBox ID="PopulationTextBox" runat="server" Text='<%# Bind("Population") %>' />
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownListCountries" runat="server" DataSourceID="EfEntityDataSourceCountries"
                            DataValueField="Id"
                            DataTextField="Name"
                            SelectedValue="<%#: BindItem.CountryId %>" />
                    </td>
                </tr>
            </EditItemTemplate>

            <EmptyDataTemplate>
                <table runat="server" style="">
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>

            <InsertItemTemplate>
                <div class="insert-item">
                    Name:
                    <asp:TextBox ID="TextBoxCountryName" runat="server" Text='<%# Bind("Name") %>' />
                    <br />
                    Population:
                    <asp:TextBox ID="TextBoxLanguage" runat="server" Text='<%# Bind("Population") %>' />
                    <br />
                    Country:
                    <asp:DropDownList ID="DropDownListCountries" runat="server" DataSourceID="EfEntityDataSourceCountries"
                        DataValueField="Id"
                        DataTextField="Name"
                        SelectedValue="<%#: BindItem.CountryId %>" />
                    <br />
                    <asp:Button ID="ButtonInsert" runat="server" CommandName="Insert" Text="Insert" />
                    <asp:Button runat="server" Text="Cancel" CommandName="Cancel" ID="ButtonCancelTownInsertion" />
                </div>
            </InsertItemTemplate>

            <ItemTemplate>
                <tr style="">
                    <td>
                        <asp:Button ID="DeleteButton" runat="server" CommandName="Delete" Text="Delete" />
                        <asp:Button ID="EditButton" runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server" Text='<%#: Eval("Name") %>' />
                    </td>
                    <td>
                        <asp:Label ID="PopulationLabel" runat="server" Text='<%#: Eval("Population") %>' />
                    </td>
                    <td>
                        <asp:Label ID="CountryLabel" runat="server" Text='<%#: Eval("Country.Name") %>' />
                    </td>
                </tr>
            </ItemTemplate>

            <LayoutTemplate>
                <table id="itemPlaceholderContainer" runat="server" border="0" style="">
                    <tr runat="server" style="">
                        <th runat="server"></th>
                        <th runat="server">Name</th>
                        <th runat="server">Population</th>
                        <th runat="server">Country</th>
                    </tr>
                    <tr runat="server" id="itemPlaceholder">
                    </tr>
                </table>
                <asp:Button runat="server" Text="Insert Town" OnClick="ButtonInsertTown_Click" ID="ButtonInsertTown" />
            </LayoutTemplate>

        </asp:ListView>
    </form>
</body>
</html>
