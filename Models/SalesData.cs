using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class SalesData
    {
        public decimal ProductId { get; set; }
        public decimal QuantitySold { get; set; }
        public decimal TotalSales { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}