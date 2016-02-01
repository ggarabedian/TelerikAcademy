namespace XmlTreeView
{
    using System;
    using System.Web.UI.WebControls;

    public partial class MenuTreeView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowResult_Click(object sender, EventArgs e)
        {
            foreach (TreeNode node in this.TreeViewMenu.CheckedNodes)
            {
                this.CheckedNodeInfo.Text = this.CheckedNodeInfo.Text + node.Text + ", ";
            }
        }
    }
}