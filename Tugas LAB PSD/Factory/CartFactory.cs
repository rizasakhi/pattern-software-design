using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Factory
{
    public class CartFactory
    {
        public static MsCart CreateCart(int userID, int supplementID, int quantity)
        {
            MsCart cart = new MsCart();
            cart.UserID = userID;
            cart.SupplementID = supplementID;
            cart.Quantity = quantity;
            return cart;
        }
    }
}