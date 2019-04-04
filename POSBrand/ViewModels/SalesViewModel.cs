using POSBrand.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSBrand.ViewModels
{
    public class SalesViewModel
    {
        public Sale Sale { get; set; }
        public SalesDetail SalesDetail { get; set; }
    }
}
