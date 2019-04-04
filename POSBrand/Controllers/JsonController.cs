using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using POSBrand.Data;

namespace POSBrand.Controllers
{
    public class JsonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JsonController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<JsonResult> GetSubCategoryList(int id)
        {
            var result = await _context.SubCategories.Where(x => x.CategoryId == id).ToListAsync();
            return Json(result);
        }

        public async Task<JsonResult> GetBrandList()
        {
            var result = await _context.Brands.ToListAsync();
            return Json(result);
        }

        public async Task<JsonResult> GetProductList(int subCategoryId, int brandId)
        {
            var result = await _context.Products
                .Where(x => x.SubCategoryId==subCategoryId && x.BrandId == brandId)
                .ToListAsync();
            return Json(result);
        }

        public async Task<JsonResult> GetProductDetail(int id)
        {
            var result = await _context.Products.FindAsync(id);
            return Json(result);
        }

        public async Task<JsonResult> GetAvailableQuantity(int id)
        {
            var result = await _context.Stocks.Where(x => x.ProductId == id)
                .OrderByDescending(x => x.StockDate)
                .FirstOrDefaultAsync();
            return Json(result);
        }
    }
}