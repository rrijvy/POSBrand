using POSBrand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSBrand.ViewModels
{
    public class PurchaseViewModel
    {
        public Purchase Purchase { get; set; }
        public PurchaseDetail PurchaseDetail { get; set; }
    }
}
