using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM.Model.Models
{
    public class UserModel
    {

        public int userId { get; set; }
        public string userFullName { get; set; }
        public string userName { get; set; }

        public string Role { get; set; }

        public string password { get; set; }
        public string confirmPassword { get; set; }
        public string Date { get; set; }


    }
}
