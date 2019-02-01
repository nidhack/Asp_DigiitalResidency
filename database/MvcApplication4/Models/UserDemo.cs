using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication4.Models
{   
   
    public class UserDemo
    {
        public int UserDemoid { get; set; }
        [Required(ErrorMessage="canot be empty")]
        [Display(Name="username")]
        public string username { get; set; }
        [Required(ErrorMessage="canot be empty")]
        [DataType(DataType.Password)]
        [Display(Name="password")]
        public string password { get; set; }



    }
}