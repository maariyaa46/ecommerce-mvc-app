using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject.Models
{
    public class Order
    {
        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public decimal userid { get; set; }
        public Nullable<int> paymentid { get; set; }
        public decimal shippingid { get; set; }
        public decimal total { get; set; }


        public virtual User User { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Shipping Shipping { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
