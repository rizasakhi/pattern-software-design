using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using Tugas_LAB_PSD.Handler;
using Tugas_LAB_PSD.Model;
using Tugas_LAB_PSD.Modules;

namespace Tugas_LAB_PSD.Controller
{
    public class CartController
    {
        public static Response<MsCart> UpdateCart(int userId, int supplementId, string quantity)
        {
            string errorMessage = string.Empty;

            if (quantity == string.Empty)
            {
                errorMessage = "Quantity is required.";
            }
            else if (Convert.ToInt32(quantity) <= 0)
            {
                errorMessage = "Quantity must be bigger than 0.";
            }

            if (!errorMessage.Equals(string.Empty))
            {
                return new Response<MsCart>()
                {
                    Success = false,
                    Message = errorMessage,
                    Payload = null
                };
            }
            
            return CartHandler.UpdateCart(userId, supplementId, Convert.ToInt32(quantity));
        }
    }
}