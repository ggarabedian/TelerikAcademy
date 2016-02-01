namespace TheLastTableOfEmployees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI.WebControls;

    using DataBinding.Data;

    public partial class Employees : System.Web.UI.Page
    {
        private NorthwindEntities context = new NorthwindEntities();

        int PageIndex //we maintain the page index in the view state,so that the value can persist across postback
        {
            get
            {
                if (ViewState["PageIndex"] != null)
                    return Convert.ToInt32(ViewState["PageIndex"]);
                else
                    return 0;
            }
            set { ViewState["PageIndex"] = value; }
        }
        SortDirection CurrentSortDirection //Stores direction of sorting.i.e. Ascending or descending
        {
            get
            {
                if (ViewState["SortDirection"] != null)
                    return (SortDirection)Enum.Parse(typeof(SortDirection), ViewState["SortDirection"].ToString());
                else
                    return 0;
            }
            set { ViewState["SortDirection"] = value; }
        }
        public string CurrentSortExpression //Sort expression is used to filter out the data from result set.
        {
            get
            {
                if (ViewState["SortExpression"] != null)
                    return Convert.ToString(ViewState["SortExpression"]);
                else
                    return string.Empty;
            }
            set { ViewState["SortExpression"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                BindEmployees();
                BindPager();
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            BindEmployees();
            BindPager();
        }

        private int pageSize = 5; //we want to display only five elements in the page
        private int recordCount = 0;

        public void BindEmployees()
        {
            var res = context.Employees;

            recordCount = res.Count();
            this.EmployeesGridView.DataSource = res.OrderBy(x => x.FirstName).Skip(PageIndex * pageSize).Take(pageSize).ToList();
            this.EmployeesGridView.DataBind();
        }
        private void BindPager()
        {
            if (PageIndex == (recordCount / pageSize))
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
            if (PageIndex == 0)
            {
                btnPrev.Enabled = false;
            }
            else
            {
                btnPrev.Enabled = true;
            }
        }

        protected void BtnNext_Click(object sender, EventArgs e)
        {
            PageIndex = PageIndex + 1;
            BindEmployees();
            BindPager();
        }

        protected void BtnPrev_Click(object sender, EventArgs e)
        {
            PageIndex = PageIndex - 1;
            BindEmployees();
            BindPager();
        }

        protected void SortEmployees(object sender, GridViewSortEventArgs e)
        {

            if (CurrentSortDirection == SortDirection.Ascending)
            {
                CurrentSortExpression = e.SortExpression + " " + SortDirection.Descending.ToString();
                CurrentSortDirection = SortDirection.Descending;
            }
            else
            {
                CurrentSortExpression = e.SortExpression + " " + SortDirection.Ascending.ToString();
                CurrentSortDirection = SortDirection.Ascending;
            }

            BindEmployees();
            BindPager();
        }
    }
}