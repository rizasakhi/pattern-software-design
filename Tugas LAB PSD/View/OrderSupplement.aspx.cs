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
    public partial class OrderSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            List<MsSupplement> supplements = SupplementRepository.GetAllSupplements();
            if (supplements != null)
            {
                SupplementGV.DataSource = supplements;
                SupplementGV.DataBind();
            }
        }

        protected void SupplementGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            MsUser user = (MsUser)Session["user"];
            int id = user.UserID;
            if (e.CommandName == "Order")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = SupplementGV.Rows[rowIndex];

                TextBox txtQuantity = (TextBox)row.FindControl("txtQuantity");
                int quantity = Convert.ToInt32(txtQuantity.Text);

                int supplementID = Convert.ToInt32(row.Cells[0].Text); 
                DateTime expiryDate = Convert.ToDateTime(row.Cells[2].Text); 
                int price = Convert.ToInt32(row.Cells[3].Text);
                int supplementTypeID = Convert.ToInt32(row.Cells[4].Text);
                string suppName = row.Cells[1].Text;

                CartRepository.CreateCart(id, supplementID, quantity);
                //CartGV.DataSource = CartRepository.getAllUserCart(id);
                //CartGV.DataBind();
                // Refresh the cart GridView


            }
        }
    }
}