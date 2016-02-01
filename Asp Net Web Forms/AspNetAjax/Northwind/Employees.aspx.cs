namespace Northwind
{
    using System;
    using System.Linq;
    using System.Web.UI.WebControls;

    using Northwind.Data;

    public partial class Employees : System.Web.UI.Page
    {
        NorthwindEntities dbContext;

        public Employees()
        {
            this.dbContext = new NorthwindEntities();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Employee> GridViewEmployees_GetData()
        {
            return dbContext.Employees.OrderBy(x => x.EmployeeID);
        }

        protected void GridViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            var row = GridViewEmployees.SelectedRow;
            int id = int.Parse(GridViewEmployees.DataKeys[row.RowIndex].Value.ToString());

            System.Threading.Thread.Sleep(2000);

            this.GridViewOrders.Visible = true;
            this.GridViewOrders.DataSource = this.dbContext.Orders.Where(o => o.EmployeeID == id).ToList();
            this.GridViewOrders.DataBind();
        }
    }
}