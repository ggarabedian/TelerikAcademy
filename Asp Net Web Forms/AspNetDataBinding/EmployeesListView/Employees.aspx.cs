namespace EmployeesListView
{
    using System;
    using System.Linq;
    using System.Web.UI.WebControls;

    using Data;

    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employees = new NorthwindEntities1().Employees.ToList();

            this.ListViewEmployees.DataSource = employees;
            this.ListViewEmployees.DataBind();
        }
    }
}