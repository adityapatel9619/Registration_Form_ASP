using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NewRegistrationForm
{
    public partial class Registration : System.Web.UI.Page
    {
        protected System.Web.UI.HtmlControls.HtmlInputFile InputFile;
        protected System.Web.UI.HtmlControls.HtmlInputButton InputButton;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            message.Text = "Hello " + username.Text + " !";
            message.Text = message.Text + "<br/> Successfuly Registered";

            ShowUserName.Text = username.Text;
            ShowEmail.Text = EmailID.Text;

            if (RadioButton1.Checked)
            {
                ShowGender.Text = RadioButton1.Text;
            }
            else
            {
                ShowGender.Text = RadioButton2.Text;
            }

            var courses = "";
            if (CheckBox1.Checked)
            {
                courses = CheckBox1.Text + ", ";
            }
            if (CheckBox2.Checked)
            {
                courses += CheckBox2.Text + ", ";
            }
            if (CheckBox3.Checked)
            {
                courses += CheckBox3.Text;
            }

            ShowCourses.Text = courses;
            ShowUserNameLabel.Text = "User Name";
            ShowEmailIDLabel.Text = "Email Id";
            ShowGenderLabel.Text = "Gender";
            ShowCourseLabel.Text = "Courses";

            username.Text = "";
            EmailID.Text = "";

            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            CheckBox1.Checked = false;
            CheckBox2.Checked = false;
            CheckBox3.Checked = false;
        }
    }
}