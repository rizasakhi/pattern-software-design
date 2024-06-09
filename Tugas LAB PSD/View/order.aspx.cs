using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_LAB_PSD.Controller;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.View
{
    public partial class order : System.Web.UI.Page
    {
        Database1Entities2 db = new Database1Entities2 ();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["user"] == null)
            //{
            //    Response.Redirect("~/View/Login.aspx");
            //}
            if (!IsPostBack)
            {
                List<MsSupplement> supplement = db.MsSupplements.ToList();

                supplementGridView.DataSource = supplement;
                supplementGridView.DataBind();
            }
        }

        protected void supplementGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "order")
            {
                Control sourceControl = e.CommandSource as Control;
                GridViewRow row = sourceControl.NamingContainer as GridViewRow;

                int rowIndex = row.RowIndex;
                int supplementId = Convert.ToInt32(supplementGridView.Rows[rowIndex].Cells[0].Text);
                TextBox txtQuantity = supplementGridView.Rows[rowIndex].Cells[5].FindControl("TxtQuantity") as TextBox;
                string quantity = txtQuantity.Text;
                txtQuantity.Text = string.Empty;

                var response = CartController.UpdateCart(rowIndex, supplementId, quantity);

                if (response.Success)
                {
                    Response.Redirect("~/View/HomePage.aspx");
                }
                else
                {
                    ErrorLabel.Text = response.Message;
                }
                Debug.Print("test");
            }
        }
    }
}