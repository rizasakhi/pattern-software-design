using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tugas_LAB_PSD.View
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void UpdateProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfile.aspx");
        }

        protected void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdatePassword.aspx");
        }
    }
}