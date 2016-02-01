namespace EmployeesTwoPages
{
    using System;
    using System.Linq;
    using System.Web.UI.WebControls;

    using DataBinding.Data;

    public partial class EmployeeDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var id = int.Parse(Request.QueryString["id"]);
            var employee = new NorthwindEntities().Employees.Where(emp => emp.EmployeeID == id).ToList();
            this.DetailsViewEmployee.DataSource = employee;
            this.DataBind();
        }
    }
}