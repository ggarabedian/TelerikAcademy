namespace EmployeesTable
{
    using System;
    using System.Linq;

    using DataBinding.Data;

    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employees = new NorthwindEntities().Employees.ToList();

            this.RepeaterEmployees.DataSource = employees;
            this.RepeaterEmployees.DataBind();
        }
    }
}