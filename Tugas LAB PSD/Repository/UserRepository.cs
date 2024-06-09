using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Factory;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Repository
{
    public class UserRepository
    {
        public static String CreateUser(String username, String email, String gender, String password, DateTime DOB, String role)
        {
            Database1Entities2 db = new Database1Entities2();
            MsUser user = UserFactory.CreateUser(username, email, gender, password, DOB, role);
            db.MsUsers.Add(user);
            db.SaveChanges();
            return "Registration successed";
        }

        public static MsUser LoginUser(String username, String password)
        {
            Database1Entities2 db = new Database1Entities2();
            MsUser loginUser = (from x in db.MsUsers where x.UserName == username && x.UserPassword == password select x).FirstOrDefault();
            return loginUser;
        }

        public static void UpdateProfile(int id, MsUser NewUser)
        {
            Database1Entities2 db = new Database1Entities2();
            MsUser OldUser = db.MsUsers.Find(id);
            OldUser.UserName = NewUser.UserName;
            OldUser.UserGender = NewUser.UserGender;
            OldUser.UserRole = NewUser.UserRole;
            OldUser.UserPassword = NewUser.UserPassword;
            OldUser.UserDOB = NewUser.UserDOB;
            OldUser.UserEmail = NewUser.UserEmail;
            db.SaveChanges();
        }

        public static MsUser CheckUser(String username)
        {
            Database1Entities2 db = new Database1Entities2();
            MsUser loginUser = (from x in db.MsUsers where x.UserName == username select x).FirstOrDefault();
            return loginUser;
        }
    }
}