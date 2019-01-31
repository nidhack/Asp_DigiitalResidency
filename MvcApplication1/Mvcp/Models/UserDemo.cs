using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Mvcp.Models
{
    public class UserDemo
    {

        public int UserDemoid { get; set; }
         [Display(Name="User Name")]
        [Required(ErrorMessage="Enter Name")]
        public string username { get; set; }
         [Display(Name="User Password")]
        [Required(ErrorMessage="Enter Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
}