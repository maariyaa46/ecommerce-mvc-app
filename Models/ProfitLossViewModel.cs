using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    
        public class ProfitLossViewModel
        {
            public Nullable<decimal> TotalRevenue { get; set; }
            public Nullable<decimal> TotalCost { get; set; }
            public Nullable<decimal> Profit { get; set; }
        }
    }
