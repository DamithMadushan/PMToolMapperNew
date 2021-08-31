using PTM.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.DBAccess.DBModel
{
    public static class UserDBAccess
    {

        public static bool checkUser(UserModel userLogin)
        {

            using(PMToolMapperDBEntities db = new PMToolMapperDBEntities())
            {

                var countUser = db.UserLogins.Where(x => x.UserName == userLogin.userName && x.Password == userLogin.password).FirstOrDefault();

                if(countUser != null && countUser.UserId > 0)
                {

                    UserDataModel.UserId = countUser.UserId;
                    UserDataModel.UserName = userLogin.userName;


                    return true;
                }
                else
                {
                    return false;
                }
            }




        }


        public static List<UserLogin> getUsers()
        {

            using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
            {

                List<UserLogin> userLogins = db.UserLogins.ToList();

                return userLogins;

            }

        }

        public static bool addUser(UserModel userLogin)
        {

            using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
            {

                UserLogin userLoginData = new UserLogin() { 
                
                    UserFullName = userLogin.userFullName,
                    UserName = userLogin.userName,
                    Role = userLogin.Role,
                    Password = userLogin.password,
                    Date = userLogin.Date
                
                
                };

                db.UserLogins.Add(userLoginData);

                db.SaveChanges();

                int userID = Convert.ToInt32(userLoginData.UserId);

                if (userID > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }




        }

        public static bool UpdateUser(UserModel userModel)
        {
            UserLogin userUpdateData;

            using (PMToolMapperDBEntities db = new PMToolMapperDBEntities())
            {

                if (userModel.password != "")
                {
                    userUpdateData = new UserLogin()
                    {
                        UserId = userModel.userId,
                        UserFullName = userModel.userFullName,
                        UserName = userModel.userName,
                        Role = userModel.Role,
                        Password = userModel.password,
                        Date = userModel.Date


                    };
                }
                else
                {
                    userUpdateData = new UserLogin()
                    {
                        UserId = userModel.userId,
                        UserFullName = userModel.userFullName,
                        UserName = userModel.userName,
                        Role = userModel.Role,
                        Password = userModel.password,
                        Date = userModel.Date


                    };

                }

                var result = db.UserLogins.SingleOrDefault(b => b.UserId == userUpdateData.UserId);
                if (result != null)
                {
  
                    db.Entry( db.UserLogins.FirstOrDefault(x => x.UserId == userUpdateData.UserId)).CurrentValues.SetValues(userUpdateData);
  
                    return ( db.SaveChanges()) > 0;

                }
                else
                {
                    return false;
                }
            }






        }
    }
}
