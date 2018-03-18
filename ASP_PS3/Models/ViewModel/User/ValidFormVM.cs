using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP_PS3.Models.ViewModel.User
{
    /// <summary>
    /// Class contain propeties for forms to generate user in database.
    /// </summary>
    public class ValidFormVM : Models.User.UserFrame
    {
        [Required]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĘŁŃÓŚŹŻ]+$")]
        public new string FirstName { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĘŁŃÓŚŹŻ]+$")]
        public new string LastName { get; set; }
        [Range(0, 150)]
        public new int Age { get; set; }
    }
}