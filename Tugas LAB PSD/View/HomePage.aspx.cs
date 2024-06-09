using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                MsUser CurrentUser = (MsUser)Session["user"];
                String name = CurrentUser.UserName;
                if (CurrentUser.UserRole == "Admin")
                {
                    userRoleLbl.Text = "Hi, " + name + " (Admin)";
                }
                else if (CurrentUser.UserRole == "Customer")
                {
                    userRoleLbl.Text = "Hi, " + name + " (Customer)";
                }
            }
        }
    }
}