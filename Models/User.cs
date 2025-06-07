using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [Required(ErrorMessage = "Enter username")]
        [RegularExpression("^[a-zA-Z_\\.-]+$", ErrorMessage = "Only alphabets are allowed in the username.")]
        public string name { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail id is not valid")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Compare("Password", ErrorMessage = "Plese confirm your password. ")]

        public string confirm { get; set; }
        public string type { get; set; }

        



    }
}
