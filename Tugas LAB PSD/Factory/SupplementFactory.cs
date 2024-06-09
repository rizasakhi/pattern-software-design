using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Factory
{
    public class SupplementFactory
    {
        public static MsSupplement Create(String supplementName, DateTime expiryDate, int price, int typeID)
        {
            MsSupplement supplement = new MsSupplement()
            {
                SupplementName = supplementName,
                SupplementExpiryDate = expiryDate,
                SupplementPrice = price,
                SupplementTypeID = typeID
            };
            return supplement;
        }
    }
}