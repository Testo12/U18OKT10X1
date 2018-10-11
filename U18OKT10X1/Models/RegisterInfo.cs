using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace U18OKT10X1.Models
{
    public class RegisterInfo
    {
        [Required(ErrorMessage = "Please Eneter Your Name")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Please Eneter Your Email")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Please Eneter Your Phone number")]
        public String Phone { get; set; }

        [Required(ErrorMessage = "Please Enter Your Adress")]
        public String Home { get; set; }

        [Required(ErrorMessage = "Please Enter Your Driver licens information")]
        public bool Licens { get; set; }

    }
}