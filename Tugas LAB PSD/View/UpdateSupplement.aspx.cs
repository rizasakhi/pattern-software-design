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
    public partial class UpdateSupplement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SupplementTypeRepository STRepo = new SupplementTypeRepository();
            if (IsPostBack == false)
            {
                List<String> supplementTypeName = STRepo.GetSupplementTypeName();
                SupplementTypeDropDown.DataSource = supplementTypeName;
                SupplementTypeDropDown.DataBind();
            }

            nameLbl.Text = "Supplement name: " + Request.QueryString["name"];
            dateLbl.Text = "Supplement expiry date: " + Request.QueryString["date"];
            priceLbl.Text = "Supplement price: " + Request.QueryString["price"];
            typeidLbl.Text = "Supplement type id: " + Request.QueryString["typeid"];

            /*nameLbl.Text = Request.QueryString["name"];*/
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            String name = SuplementNameTxt.Text;
            DateTime expiryDate = DateTime.Parse(SupplementExDateTxt.Text);
            int price = Convert.ToInt32(SupplementPriceTxt.Text);
            String supplementDropDown = SupplementTypeDropDown.Text;
            int typeId = SupplementTypeRepository.GetSupplementTypeIDByName(supplementDropDown);

            MsSupplement checkSupplement = SupplementRepository.CheckSupplement(name);

            if (checkSupplement != null)
            {
                errorLbl.Text = "Supplement already exist";
                return;
            }
            else if (name == "" || SupplementExDateTxt.Text == "" || SupplementPriceTxt.Text == "" || SupplementTypeDropDown.Text == "")
            {
                errorLbl.Text = "All field must be filled";
                return;
            }
            else if (!name.Contains("Supplement") && !name.Contains("supplement"))
            {
                errorLbl.Text = "Name must contain Supplement";
                return;
            }
            else if (expiryDate > DateTime.Now)
            {
                errorLbl.Text = "Expiry date must be greater than today's date";
                return;
            }
            else if (price < 3000)
            {
                errorLbl.Text = "price must be at least 3000";
                return;
            }

            MsSupplement supp = SupplementFactory.Create(name, expiryDate, price, typeId);
            SupplementRepository.UpdateSupplementByID(name, supp);

            Response.Redirect("~/View/ManageSupplement.aspx");
        }

        protected void backToManage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ManageSupplement.aspx");
        }
    }
}