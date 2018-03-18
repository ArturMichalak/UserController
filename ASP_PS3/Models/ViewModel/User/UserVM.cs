using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_PS3.Models.User;

namespace ASP_PS3.Models.ViewModel.User
{
    public class UserVM
    {
        public List<UserDB> Users { get; set; }
        public UserVM(List<UserDB> userList)
        {
            Users = userList;
        }
    }
}