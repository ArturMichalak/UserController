using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP_PS3.Models.User;

namespace ASP_PS3.Models.ViewModel.User
{
    public class DetailsVM
    {
        public UserDB User { get; set; }
        public DetailsVM(List<UserDB> userList, int id)
        {
            User = userList.Find(x => x.Identifier == id);
        }
    }
}