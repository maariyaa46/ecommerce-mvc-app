using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FinalProject.Models
{
    public class Shipping
    {
        public Shipping()
        {
            this.Orders = new HashSet<Order>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }


        public decimal postalcode { get; set; }
        public string state { get; set; }

       
        
        public string contactnum { get; set; }

        public string city { get; set; }
        public string address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }


    }
}