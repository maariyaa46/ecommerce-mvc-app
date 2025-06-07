using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinalProject.Models
{
    public class Brand
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        public string name { get; set; }
        public decimal subcategoryid { get; set; }

        public string type { get; set; }



    }
}