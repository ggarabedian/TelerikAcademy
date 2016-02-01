namespace EmployeesSinglePage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.UI.WebControls;

    using DataBinding.Data;

    public partial class Employees : System.Web.UI.Page
    {
        List<Employee> employees = new NorthwindEntities().Employees.ToList();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                this.employees = (List<Employee>)ViewState["employees"];
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.FormViewEmployees.DataSource = this.employees;
            this.FormViewEmployees.DataBind();
            ViewState["employees"] = this.employees;
        }

        protected void FormViewEmployees_OnPageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            this.FormViewEmployees.PageIndex = e.NewPageIndex;
            this.FormViewEmployees.DataSource = this.employees;
            this.FormViewEmployees.DataBind();
        }
    }
}