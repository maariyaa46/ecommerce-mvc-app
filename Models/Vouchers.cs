using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Vouchers
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime Expiredate { get; set; }
        public decimal userid { get; set; }
        public decimal discount { get; set; }
        public string code { get; set; }
    }
}
