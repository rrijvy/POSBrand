using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSBrand.Data;

namespace POSBrand.Controllers
{
    public class InvoiceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InvoiceController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> SalesInvoice(int id)
        {
            var result = await _context.Sales
                .Where(x => x.OrderRefNo == id.ToString())
                .Include(x => x.Customer)
                .Include(x => x.SalesDetails)
                .ThenInclude(x => x.Product)
                .FirstOrDefaultAsync();

            return View(result);
        }

        public async Task<IActionResult> PurchaseInvoice(int id)
        {
            var result = await _context.Purchases
                .Where(x => x.OrderRefNo == id.ToString())
                .Include(x => x.Supplier)
                .Include(x => x.PurchaseDetails)
                .ThenInclude(x => x.Product)
                .FirstOrDefaultAsync();

            return View(result);
        }
    }
}