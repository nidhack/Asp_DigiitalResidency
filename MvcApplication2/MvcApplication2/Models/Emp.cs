using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication2.Models
{
    public class Emp
    {   [Required]
       
        [Display(Name="ename")]
        public string ename { get; set; }
        [Required]
         [Display(Name="email")]
         [DataType(DataType.EmailAddress)]
        public string email { get; set; }
         [Display(Name = "address")]
        public string eaddress { get; set; }
         [Display(Name= "Salary")]
         [Range(1000,10000,ErrorMessage="Enter valid amount")]
        public string esal { get; set; }
    }
}