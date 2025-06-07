
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProject.Models
{
    public class Wishlist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }
        public decimal userid { get; set; }
        public decimal productid { get; set; }
        public Nullable<bool> isActive { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }
    }
}
