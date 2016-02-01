namespace EmployeesTwoPages
{
    using System;
    using System.Linq;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    using DataBinding.Data;

    public partial class Employees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employees = from employee in new NorthwindEntities().Employees.ToList()
                            select new { FullName = employee.FirstName + " " + employee.LastName, Id = employee.EmployeeID };

            if (!Page.IsPostBack)
            {
                this.GridViewEmployees.DataSource = employees;
                this.DataBind();
            }
        }
    }
}