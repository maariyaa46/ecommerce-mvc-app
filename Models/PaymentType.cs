using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class PaymentType
    {
        public PaymentType()
        {
            this.Payments = new HashSet<Payment>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string type { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}