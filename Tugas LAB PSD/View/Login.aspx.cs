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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            /*if (Session["user"] != null || Request.Cookies["UserCookie"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }*/
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;
            Boolean remember = rememberCbox.Checked;

            if (username == "" || password == "")
            {
                errorLbl.Text = "All field must be filled";
                return;
            }

            MsUser loginuser = UserRepository.LoginUser(username, password);
            if (loginuser == null)
            {
                errorLbl.Text = "Account doesn't found";
                return;
            }
            else
            {
                HttpCookie cookie = new HttpCookie("UserCookie");
                cookie.Value = loginuser.UserID.ToString();
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);

                Session["user"] = loginuser;
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void toRegisterLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }
    }
}