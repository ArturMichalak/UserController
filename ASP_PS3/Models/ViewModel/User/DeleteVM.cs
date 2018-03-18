using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_PS3.Models.User;

namespace ASP_PS3.Models.ViewModel.User
{
    public class DeleteVM
    {
        public UserDB User { get; set; }
        public DeleteVM(List<UserDB> userList, int id)
        {
            User = userList.Find(x => x.Identifier == id);
        }
    }
}