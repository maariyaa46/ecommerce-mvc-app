using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class CustomerReport
    {
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public decimal TotalOrders { get; set; }
        public decimal TotalSales { get; set; }
    }
}