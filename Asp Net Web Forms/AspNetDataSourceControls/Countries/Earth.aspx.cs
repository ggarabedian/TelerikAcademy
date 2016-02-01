namespace Countries
{
    using System;
    using System.Linq;
    using System.Data.Entity.Infrastructure;
    using System.Web.UI.WebControls;

    using Data;

    public partial class Earth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EfEntityDataSource_ContextCreating(object sender, Microsoft.AspNet.EntityDataSource.EntityDataSourceContextCreatingEventArgs e)
        {
            var db = new EarthDbContext();
            e.Context = (db as IObjectContextAdapter).ObjectContext;
        }

        protected void ButtonInsertCountry_Click(object sender, EventArgs e)
        {
            this.ListViewInsertCountryForm.InsertItemPosition = InsertItemPosition.LastItem;
            HideInsertCountryButton();
        }

        protected void ListViewInsertCountryForm_ItemInserted(object sender, ListViewInsertedEventArgs e)
        {
            this.ListViewInsertCountryForm.InsertItemPosition = InsertItemPosition.None;
            ShowInsertCountryButton();
        }

        protected void ButtonInsertTown_Click(object sender, EventArgs e)
        {
            this.ListViewTowns.InsertItemPosition = InsertItemPosition.LastItem;
            HideInsertTownButton();
        }

        protected void ButtonEditCategory_Click(object sender, EventArgs e)
        {
            this.ListViewTowns.InsertItemPosition = InsertItemPosition.LastItem;
        }

        protected void ListViewTowns_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            this.ListViewTowns.InsertItemPosition = InsertItemPosition.None;
            ShowInsertTownButton();
        }

        protected void ListViewInsertCountryForm_ItemCanceling(object sender, ListViewCancelEventArgs e)
        {
            this.ListViewInsertCountryForm.InsertItemPosition = InsertItemPosition.None;
            ShowInsertCountryButton();
        }

        private void ShowInsertCountryButton()
        {
            Button insertCountryButton = (Button)this.ListViewInsertCountryForm.FindControl("ButtonInsertCountry");
            insertCountryButton.Visible = true;
        }

        private void HideInsertCountryButton()
        {
            Button insertCountryButton = (Button)this.ListViewInsertCountryForm.FindControl("ButtonInsertCountry");
            insertCountryButton.Visible = false;
        }

        private void ShowInsertTownButton()
        {
            Button insertCountryButton = (Button)this.ListViewTowns.FindControl("ButtonInsertTown");
            insertCountryButton.Visible = true;
        }

        private void HideInsertTownButton()
        {
            Button insertCountryButton = (Button)this.ListViewTowns.FindControl("ButtonInsertTown");
            insertCountryButton.Visible = false;
        }
    }
}