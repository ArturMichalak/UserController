using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using ASP_PS3.Models.User;

namespace ASP_PS3.Models.ViewModel.User
{
    public class EditVM
    {
        public UserFrame User { get; set; }
        public EditVM(List<UserDB> userList, int id)
        {
            User = userList.Find(x => x.Identifier == id);
        }
    }
}