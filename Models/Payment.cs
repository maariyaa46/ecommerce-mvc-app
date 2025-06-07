using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Payment
    {
        public Payment()
        {
            this.Orders = new HashSet<Order>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int type { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual PaymentType PaymentType { get; set; }




    }
}
