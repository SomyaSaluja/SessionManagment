using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace UserSessionManagment.Models
{
    public class UserModel
    {
       [Required(ErrorMessage="this field is required.")]
       [Display(Name="Enter Username :")]
        public string Name { get; set; }

       [Required(ErrorMessage = "this field is required.")]
       [Display(Name = "Enter Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set;}
    }
}