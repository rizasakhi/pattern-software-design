using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.WebParts;
using Tugas_LAB_PSD.Factory;
using Tugas_LAB_PSD.Model;
using Tugas_LAB_PSD.Modules;
using Tugas_LAB_PSD.Repository;

namespace Tugas_LAB_PSD.Handler
{
    public class CartHandler
    {
        public static Response<MsCart> UpdateCart(int userId, int supplementId, int quantity)
        {
            MsCart searchedCart = CartRepository.GetCartByUserIdAndSupplementId(userId, supplementId);

            MsCart cart;

            // Cart belum ada
            if (searchedCart == null)
            {
                cart = CartRepository.CreateCart(userId, supplementId, quantity);

                return new Response<MsCart>()
                {
                    Success = true,
                    Message = "Successfully create cart",
                    Payload = cart
                };
            }

            // Cart sudah ada
            cart = searchedCart;
            cart.CartID = searchedCart.CartID;
            cart.Quantity += searchedCart.Quantity;
            bool isUpdated = CartRepository.UpdateCart(cart);

            if (!isUpdated)
            {
                return new Response<MsCart>()
                {
                    Success = false,
                    Message = "Failed to update cart",
                    Payload = null
                };
            }

            return new Response<MsCart>()
            {
                Success = true,
                Message = "Successfully update cart",
                Payload = cart
            };
        }
    }
}