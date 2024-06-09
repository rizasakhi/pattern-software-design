using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Factory;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Repository
{
    public class CartRepository
    {
        public static MsCart CreateCart(int userID, int supplementID, int quantity)
        {
            Database1Entities2 db = new Database1Entities2();
            MsCart cart = CartFactory.CreateCart(userID, supplementID, quantity);
            db.MsCarts.Add(cart);
            db.SaveChanges();
            return cart;
        }

        public static MsCart GetCartByUserIdAndSupplementId(int userId, int supplementId)
        {
            Database1Entities2 db = new Database1Entities2();
            return db.MsCarts.Where(x => x.UserID == userId && x.SupplementID == supplementId).FirstOrDefault();
        }

        public static bool UpdateCart(MsCart cart)
        {
            Database1Entities2 db = new Database1Entities2();
            MsCart updatedCart = db.MsCarts.Find(cart.CartID);

            if (updatedCart == null)
            {
                return false;
            }

            updatedCart.Quantity = cart.Quantity;

            db.SaveChanges();
            return true;
        }
    }
}