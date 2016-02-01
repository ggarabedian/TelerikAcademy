namespace Random
{
    using System;

    public partial class RandomNumberGenerator : System.Web.UI.Page
    {
        private readonly Random rand = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenerateRandomHtml_Click(object sender, EventArgs e)
        {
            var minNumber = int.Parse(this.TextBoxMinNumber.Value);
            var maxNumber = int.Parse(this.TextBoxMaxNumber.Value);

            var randomNumber = rand.Next(minNumber, maxNumber + 1);

            this.ResultHtml.InnerText = randomNumber.ToString();
        }

        protected void GenerateRandomWeb_Click(object sender, EventArgs e)
        {
            var minNumber = int.Parse(this.TbMinNumber.Text);
            var maxNumber = int.Parse(this.TbMaxNumber.Text);

            var randomNumber = rand.Next(minNumber, maxNumber + 1);

            this.ResultWeb.Text = randomNumber.ToString();
        }
    }
}