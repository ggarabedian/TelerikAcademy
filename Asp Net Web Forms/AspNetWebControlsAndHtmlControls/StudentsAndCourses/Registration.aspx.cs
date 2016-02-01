namespace StudentsAndCourses
{
    using System;
    using System.Web.UI.WebControls;

    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            var fullName = this.TextBoxFirstName.Text + " " + this.TextBoxLastName.Text;
            var facultyNumber = this.TextBoxFacultyNumber.Text;
            var school = this.DropdownSchool.SelectedItem.Text;
            var specialty = this.DropDownSpecialty.SelectedItem.Text;
            var courses = this.ListBoxCourses;

            this.registeredUserInfo.InnerHtml = "<h1>Full Name: " + fullName + "</h1>" +
                                                    "<h4>Faculty Number: " + facultyNumber + "</h4>" +
                                                    "<h4>School: " + school + "</h4>" +
                                                    "<h4>Specialty: " + specialty + "</h4>" +
                                                    "<h4>Courses: </h4>";

            foreach (ListItem item in courses.Items)
            {
                if (item.Selected)
                {
                    this.registeredUserInfo.InnerHtml += "<h5>" + item.Text + "</h5>";
                }
            }
        }
    }
}