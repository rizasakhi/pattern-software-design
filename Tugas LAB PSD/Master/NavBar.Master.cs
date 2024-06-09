using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Master
{
    public partial class NavBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                toLoginBtn.Visible = false;
                toRegisterBtn.Visible = false;

                MsUser CurrentUser = (MsUser)Session["user"];
                if (CurrentUser.UserRole.Contains("Admin"))
                {
                    toOrderBtn.Visible = false;
                    toHistoryBtn.Visible = false;
                    toHomeBtn.Visible = true;
                    toManageBtn.Visible = true;
                    toOrderQueueBtn.Visible = true;
                    toReportBtn.Visible = true;
                    toProfileBtn.Visible = true;
                    toLogoutBtn.Visible = true;
                }
                else if (CurrentUser.UserRole.Contains("Customer"))
                {
                    toOrderBtn.Visible = true;
                    toHistoryBtn.Visible = true;
                    toHomeBtn.Visible = false;
                    toManageBtn.Visible = false;
                    toOrderQueueBtn.Visible = false;
                    toReportBtn.Visible = false;
                    toProfileBtn.Visible = true;
                    toLogoutBtn.Visible = true;
                }
            }
            else
            {
                toLoginBtn.Visible = true;
                toRegisterBtn.Visible = true;

                toOrderBtn.Visible = false;
                toHistoryBtn.Visible = false;
                toHomeBtn.Visible = false;
                toManageBtn.Visible = false;
                toOrderQueueBtn.Visible = false;
                toReportBtn.Visible = false;
                toProfileBtn.Visible = false;
                toLogoutBtn.Visible = false;
            }
        }

        protected void toOrderBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/OrderSupplement.aspx");
        }

        protected void toHistoryBtn_Click(object sender, EventArgs e)
        {

        }

        protected void toHomeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void toManageBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageSupplement.aspx");
        }

        protected void toOrderQueueBtn_Click(object sender, EventArgs e)
        {

        }

        protected void toReportBtn_Click(object sender, EventArgs e)
        {

        }

        protected void toProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Profile.aspx");
        }

        protected void toLogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("~/View/Login.aspx");
        }

        protected void toLoginBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Login.aspx");
        }

        protected void toRegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Register.aspx");
        }
    }
}