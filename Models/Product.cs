using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace FinalProject.Models
{
    public class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
            this.Reviews = new HashSet<Reviews>();
            this.Wishlist = new HashSet<Wishlist>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }
        public string name { get; set; }
       
        public decimal stocklevel { get; set; }
        public decimal price { get; set; }


        public decimal subcategoryid { get; set; }
        public string description { get; set; }
        public string path { get; set; }

        [NotMapped]
        public HttpPostedFileBase imgFile { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
        public virtual ICollection<Wishlist> Wishlist { get; set; }




    }
}