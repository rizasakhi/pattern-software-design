using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Factory
{
    public class SupplementTypeFactory
    {
        public static MsSupplementType Create(String supplementTypeName)
        {
            MsSupplementType supplementType = new MsSupplementType()
            {
                SupplementTypeName = supplementTypeName
            };

            return supplementType;
        }
    }
}