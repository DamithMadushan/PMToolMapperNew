using PTM.DBAccess.DBModel;
using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.BusinessLogic.Services
{
    public static class UserService
    {

        public static bool Login(string userName,string password)
        {

            UserModel userModel = new UserModel() {

                userName = userName,
                password = password,

            };



            if (UserDBAccess.checkUser(userModel))
            {
                return true;
            }
            else
            {
                return false;
            }





        }


        public static List<UserLogin> getUserList()
        {

            return UserDBAccess.getUsers();

        }

        public static bool AddUser(UserModel userModel)
        {

            if (UserDBAccess.addUser(userModel))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public static bool UpdateUser(UserModel userModel)
        {

            if (UserDBAccess.UpdateUser(userModel))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

    }
}
