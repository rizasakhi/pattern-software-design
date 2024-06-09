using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Tugas_LAB_PSD.Model;
using Tugas_LAB_PSD.Repository;

namespace Tugas_LAB_PSD.View
{
    public partial class ManageSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            List<MsSupplement> supplements = SupplementRepository.GetAllSupplements();
            if(supplements != null)
            {
                SupplementGV.DataSource = supplements;
                SupplementGV.DataBind();
            }
        }

        protected void SupplementGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = SupplementGV.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            SupplementRepository.DeleteSupplementByID(id);
            RefreshGrid();
        }

        protected void SupplementGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = SupplementGV.Rows[e.NewEditIndex];
            /*int id = Convert.ToInt32(row.Cells[0].Text);*/
            String name = row.Cells[1].Text;
            String expirydate = row.Cells[2].Text;
            String price = row.Cells[3].Text;
            String typeid = row.Cells[4].Text;
/*            Response.Redirect("~/View/UpdateSupplement.aspx?id=" + name + expirydate + price + typeid);
*/
            Response.Redirect("~/View/UpdateSupplement.aspx?name=" + name + "expirydate=" + expirydate + "price=" + price + "typeid=" + typeid);

        }

        protected void InsertSupplementBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertSupplement.aspx");
        }
    }
}