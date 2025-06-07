using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using FinalProject.Models;

namespace FinalProject.Models
{
    public class ProductVM
    {
        public decimal id { get; set; }
        public string name { get; set; }
        public decimal stocklevel { get; set; }
        public decimal price { get; set; }
        public decimal subcategoryid { get; set; }
        public string description { get; set; }
        public string path { get; set; }

        [NotMapped]
        public HttpPostedFileBase imgFile { get; set; }

    }
}