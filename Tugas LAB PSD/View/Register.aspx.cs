using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_LAB_PSD.Model;
using Tugas_LAB_PSD.Repository;

namespace Tugas_LAB_PSD.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String email = emailTxt.Text;
            String gender = genderTxt.Text;
            String dob = dobTxt.Text;
            String password = passwordTxt.Text;
            String confirm = confirmTxt.Text;

            MsUser checkUsername = UserRepository.CheckUser(username);

            if (username == "" || email == "" || gender == "" || password == "" || confirm == "" || dob == "")
            {
                errorLbl.Text = "All field must be filled";
                return;
            }
            else if (username.Length < 5 || username.Length > 15)
            {
                errorLbl.Text = "Username must be more than 5 char and less than 15 char";
                return;
            }
            else if (email.IndexOf("@") == -1 || email.IndexOf("@") == 0 || email.IndexOf("@") == email.Length - 1 ||
                email.IndexOf(".") == -1 || email.IndexOf(".") == 0 || email.IndexOf(".") == email.Length - 1 || !email.EndsWith(".com"))
            {
                errorLbl.Text = "Email must end with .com, please check again";
                return;
            }
            else if (gender != "Male" && gender != "Female")
            {
                errorLbl.Text = "Gender must be Male or Female";
                return;
            }
            else if (password != confirm) 
            {
                errorLbl.Text = "Password doesn't match";
                return;
            }
            else if (checkUsername != null)
            {
                errorLbl.Text = "Username already exist";
                return;
            }

            DateTime dob2 = DateTime.Parse(dobTxt.Text);

            String role = "Customer";
            if (email.Contains("Admin") || email.Contains("admin"))
            {
                role = "Admin";
            }

            errorLbl.Text = UserRepository.CreateUser(username, email, gender, password, dob2, role);
            Response.Redirect("~/View/Login.aspx");
        }

        protected void toLoginLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }
    }
}