using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_PS3.Models.User
{
    public class UserDB : UserFrame
    {
        public int Identifier { get; set; }
        public bool Adult { get; set; }
    }
}