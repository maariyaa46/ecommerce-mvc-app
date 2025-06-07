using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class OrderDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }
        public decimal orderid { get; set; }
        public decimal productid { get; set; }
        public decimal discount { get; set; }
        public string code { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public decimal total { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }

    }
}
