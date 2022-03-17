using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MvcEntityframe.Models
{
    public class person
    {
        public int id { get; set; }

         [Required(ErrorMessage = "Enter First Name")]
        
        public string firstname { get; set; }


         [Required(ErrorMessage = "Enter Last Name")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Enter Email")]
         //[Display(Name = "User Email")]
         [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Invalid Email")]
        public string email { get; set; }



        [Required(ErrorMessage = "Enter Number")]
        //[DataType(DataType.PhoneNumber)]
       // [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
       // [StringLength(10, MinimumLength = 10, ErrorMessage = "invalid number")]
        //[MaxLength(10, ErrorMessage = "Customer Code is exceeding")] 
       
        public string number { get; set; }

         [Required(ErrorMessage = "Enter City ")]
        public string city { get; set; }
        
        //public List<person> user = new List<person>();
    }
}