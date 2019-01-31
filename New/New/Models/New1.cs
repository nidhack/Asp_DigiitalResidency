using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace New.Models
{
    public class New1
        
    {   public int Id{get; set;}
        [Required(ErrorMessage="enter the name")]
        [Display(Name="Name of User")]
        public string name{get; set;}
        [Required (ErrorMessage="enter the username")]
        [Display(Name = "UserName of User")]
        public string uname { get; set; }
        [Required (ErrorMessage="enter the Password")]
        [Display(Name = "Enter Password")]
        [DataType(DataType.Password)]
        public string password{get; set;}
    }
}