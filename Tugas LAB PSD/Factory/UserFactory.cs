using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tugas_LAB_PSD.Model;

namespace Tugas_LAB_PSD.Factory
{
    public class UserFactory
    {
        public static MsUser CreateUser(String username, String email, String gender, String password, DateTime DOB, String role)
        {
            MsUser user = new MsUser();
            user.UserName = username;
            user.UserEmail = email;
            user.UserGender = gender;
            user.UserPassword = password;
            user.UserDOB = DOB;
            user.UserRole = role;
            return user;
        }
    }
}