using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProject.Models
{
    public class Reviews
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public decimal userid { get; set; }
        public decimal productid { get; set; }
        public string email { get; set; }
        public string comment { get; set; }
        public Nullable<int> rate { get; set; }



    }
}