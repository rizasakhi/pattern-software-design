using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Factory;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Repository
{
    public class SupplementRepository
    {

        public static List<MsSupplement> GetAllSupplements()
        {
            Database1Entities2 db = new Database1Entities2();
            return db.MsSupplements.ToList();
        }

        public static void InsertSupplement(String name, DateTime expiryDate, int price, int TypeID)
        {
            Database1Entities2 db = new Database1Entities2();
            MsSupplement supplement = SupplementFactory.Create(name, expiryDate, price, TypeID);
            db.MsSupplements.Add(supplement);
            db.SaveChanges();
        }

        public static MsSupplement DeleteSupplementByID(int id)
        {
            Database1Entities2 db = new Database1Entities2();
            MsSupplement supplement = db.MsSupplements.Find(id);
            db.MsSupplements.Remove(supplement);
            db.SaveChanges();
            return supplement;
        }

        public static MsSupplement GetSupplementByID(int id)
        {
            Database1Entities2 db = new Database1Entities2();
            MsSupplement supplement = db.MsSupplements.Find(id);
            return supplement;
        }

        public static void UpdateSupplementByID(String name, MsSupplement newSupplement)
        {
            Database1Entities2 db = new Database1Entities2();
            MsSupplement oldSupplement = SupplementRepository.CheckSupplement(name);
            oldSupplement.SupplementName = newSupplement.SupplementName;
            oldSupplement.SupplementPrice = newSupplement.SupplementPrice;
            oldSupplement.SupplementExpiryDate = newSupplement.SupplementExpiryDate;
            oldSupplement.SupplementTypeID = newSupplement.SupplementTypeID;
            db.SaveChanges();
        }

        public static MsSupplement CheckSupplement(String name)
        {
            Database1Entities2 db = new Database1Entities2();
            MsSupplement check = (from x in db.MsSupplements where x.SupplementName == name select x).FirstOrDefault();
            return check;
        }

        public static MsSupplement thisSupplement(String name)
        {
            Database1Entities2 db = new Database1Entities2();
            MsSupplement supplement = (from x in db.MsSupplements where x.SupplementName == name select x).FirstOrDefault();
            return supplement;
        }
    }
}