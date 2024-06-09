using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_LAB_PSD.Factory;
using Tugas_LAB_PSD.Model;
using Tugas_LAB_PSD.Repository;

namespace Tugas_LAB_PSD.View
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser CurrentUser = (MsUser)Session["user"];
            NameData.Text = "Username: " + CurrentUser.UserName;
            EmailData.Text = "Email: " + CurrentUser.UserEmail;
            GenderData.Text = "Gender: " + CurrentUser.UserGender;
            DobData.Text = "DOB: " + CurrentUser.UserDOB.ToString();
            /*usernameTxt.Text = CurrentUser.UserName;
            emailTxt.Text = CurrentUser.UserEmail;
            genderTxt.Text = CurrentUser.UserGender;
            dobTxt.Text = CurrentUser.UserDOB.ToString();*/
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            MsUser CurrentUser = (MsUser)Session["user"];
            String username = usernameTxt.Text;
            String email = emailTxt.Text;
            String gender = genderTxt.Text;
            String dob = dobTxt.Text;
            String password = CurrentUser.UserPassword;
            String role = CurrentUser.UserRole;
            int id = CurrentUser.UserID;
            MsUser checkUsername = UserRepository.CheckUser(username);

            if (username == "" || email == "" || gender == "" || dob == "")
            {
                errorLbl.Text = "All field must be filled";
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
            else if (checkUsername != null)
            {
                errorLbl.Text = "Username already exist";
                return;
            }

            DateTime dob2 = DateTime.Parse(dob);
            MsUser user = UserFactory.CreateUser(username, email, gender, password, dob2, role);
            UserRepository.UpdateProfile(id, user);
            Response.Redirect("~/View/HomePage.aspx");
        }
    }
}