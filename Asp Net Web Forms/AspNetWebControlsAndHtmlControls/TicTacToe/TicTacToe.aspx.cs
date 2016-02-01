namespace TicTacToe
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Web.UI.WebControls;

    public partial class TicTacToe : System.Web.UI.Page
    {
        private static bool gameEnded = false;
        private Random rand = new Random();
        private static List<string> fields = new List<string>
        {
            "Field1", "Field2", "Field3", "Field4", "Field5", "Field6", "Field7", "Field8", "Field9",
        };

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Field_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            if (gameEnded)
            {
                return;
            }

            ImageButton playerButton = (ImageButton)sender;

            if (!fields.Contains(playerButton.ID))
            {
                this.LabelMessage.Text = "Select an empty field!";
                return;
            }
            else
            {
                fields.Remove(playerButton.ID);
            }

            playerButton.ImageUrl = "images/OField.png";
            if (IsWinningMove())
            {
                this.LabelMessage.Text = "YOU WON!";
                gameEnded = true;
                return;
            }

            if (fields.Count == 0)
            {
                this.LabelMessage.Text = "IT'S A DRAW!";
                gameEnded = true;
                return;
            }

            int index = rand.Next(0, fields.Count);
            ImageButton cpuButton = (ImageButton)this.form1.FindControl(fields[index]);
            fields.Remove(cpuButton.ID);

            cpuButton.ImageUrl = "images/XField.png";
            if (IsWinningMove())
            {
                this.LabelMessage.Text = "YOU LOST!";
                gameEnded = true;
                return;
            }
        }

        private bool IsWinningMove()
        {
            if (this.Field1.ImageUrl == this.Field2.ImageUrl && this.Field2.ImageUrl == this.Field3.ImageUrl)
            {
                if (this.Field1.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            if (this.Field4.ImageUrl == this.Field5.ImageUrl && this.Field5.ImageUrl == this.Field6.ImageUrl)
            {
                if (this.Field4.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            if (this.Field7.ImageUrl == this.Field8.ImageUrl && this.Field8.ImageUrl == this.Field9.ImageUrl)
            {
                if (this.Field7.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            if (this.Field1.ImageUrl == this.Field4.ImageUrl && this.Field4.ImageUrl == this.Field7.ImageUrl)
            {
                if (this.Field1.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            if (this.Field2.ImageUrl == this.Field5.ImageUrl && this.Field5.ImageUrl == this.Field8.ImageUrl)
            {
                if (this.Field2.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            if (this.Field3.ImageUrl == this.Field6.ImageUrl && this.Field6.ImageUrl == this.Field9.ImageUrl)
            {
                if (this.Field3.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            if (this.Field1.ImageUrl == this.Field5.ImageUrl && this.Field5.ImageUrl == this.Field9.ImageUrl)
            {
                if (this.Field1.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            if (this.Field3.ImageUrl == this.Field5.ImageUrl && this.Field5.ImageUrl == this.Field7.ImageUrl)
            {
                if (this.Field3.ImageUrl != "images/EmptyField.png")
                {
                    return true;
                }
            }

            return false;
        }

        protected void ResetButton_Click(object sender, EventArgs e)
        {
            fields = new List<string>
            {
                "Field1", "Field2", "Field3", "Field4", "Field5", "Field6", "Field7", "Field8", "Field9",
            };
            gameEnded = false;
            Response.Redirect(Request.RawUrl);
        }
    }
}