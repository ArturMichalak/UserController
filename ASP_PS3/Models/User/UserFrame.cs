using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_PS3.Models.User
{
    /// <summary>
    /// Class with parametrs to identyfi User
    /// <para>Contain id, firstName, lastName and age fields</para>
    /// </summary>
    public class UserFrame
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}
