using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MvcApplication4.Models
{
    public class Stud
    {
        public int Studid { get; set; }
        public virtual UserDemo UserDemo { get; set; }
        public int UserDemoid { get; set; }
        [Required(ErrorMessage = "canot be empty")]
        [Display(Name = "name")]
        public string name { get; set; }
        [Required(ErrorMessage = "canot be empty")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "email")]


        public string email { get; set; }
    }
    public enum Gender { male,female}
}
