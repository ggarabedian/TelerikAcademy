namespace Calculator
{
    using System;
    using System.Web.UI.WebControls;

    public partial class Calculator : System.Web.UI.Page
    {
        private static string lastOperation;
        private static long lastNumber;
        private static int clickCounter = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void NumericButton_Click(object sender, EventArgs e)
        {
            if (clickCounter == 0)
            {
                this.TextBoxScreen.Text = "";
            }

            Button button = (Button)sender;
            this.TextBoxScreen.Text += button.Text;
            clickCounter++;
        }

        protected void OperationButton_Click(object sender, EventArgs e)
        {
            if (lastOperation != null && lastNumber != 0)
            {
                switch (lastOperation)
                {
                    case "+": lastNumber += long.Parse(this.TextBoxScreen.Text); break;
                    case "-": lastNumber -= long.Parse(this.TextBoxScreen.Text); break;
                    case "*": lastNumber *= long.Parse(this.TextBoxScreen.Text); break;
                    case "/": lastNumber /= long.Parse(this.TextBoxScreen.Text); break;
                    default:
                        break;
                }

                this.TextBoxScreen.Text = lastNumber.ToString();
            }

            Button button = (Button)sender;
            lastOperation = button.Text;
            lastNumber = long.Parse(this.TextBoxScreen.Text);
            clickCounter = 0;
        }

        protected void SquareRootButton_Click(object sender, EventArgs e)
        {
            var squareRootNumber = (int)Math.Sqrt(int.Parse(this.TextBoxScreen.Text));
            lastNumber = squareRootNumber;
            this.TextBoxScreen.Text = squareRootNumber.ToString();
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            this.TextBoxScreen.Text = "";
            lastOperation = "";
            lastNumber = 0;
            clickCounter = 0;
        }
    }
}