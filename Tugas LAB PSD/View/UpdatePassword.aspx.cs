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
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            MsUser CurrentUser = (MsUser)Session["user"];
            String oldPassword = oldTxt.Text;
            String newPassword = newTxt.Text;
            String username = CurrentUser.UserName;
            String gender = CurrentUser.UserGender;
            String email = CurrentUser.UserEmail;
            String role = CurrentUser.UserRole;
            DateTime dob = CurrentUser.UserDOB;
            int id = CurrentUser.UserID;

            String check = CurrentUser.UserPassword;
            if(oldPassword == "" || newPassword == "")
            {
                errorLbl.Text = "All field must be filled";
                return;
            }
            else if(oldPassword != check)
            {
                errorLbl.Text = "Wrong password";
                return;
            }

            MsUser user = UserFactory.CreateUser(username, email, gender, newPassword, dob, role);

            UserRepository.UpdateProfile(id, user);
            /*errorLbl.Text = UserRepository.CreateUser(username, email, gender, newPassword, dob, role);*/

            Response.Redirect("~/View/HomePage.aspx");
        }
    }
}