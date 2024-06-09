using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Repository
{
    public class SupplementTypeRepository
    {

        public List<String> GetSupplementTypeName()
        {
            Database1Entities2 db = new Database1Entities2();
            return (from x in db.MsSupplementTypes select x.SupplementTypeName).ToList();
        }

        public static int GetSupplementTypeIDByName(String name)
        {
            Database1Entities2 db = new Database1Entities2();
            return (from x in db.MsSupplementTypes where x.SupplementTypeName.Equals(name) select x.SupplementTypeID).FirstOrDefault();
        }

        public static String GetSupplementTypeNameById(int id)
        {
            Database1Entities2 db = new Database1Entities2();
            return (from x in db.MsSupplementTypes where x.SupplementTypeID.Equals(id) select x.SupplementTypeName).FirstOrDefault();
        }
    }
}