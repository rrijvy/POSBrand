using POSBrand.Models;
using System;

namespace POSBrand.Services
{
    public interface IStockService
    {

        void StockMaintain(DateTime dateTime, SalesDetail salesDetail);
        void AddStockDetail(string remarks, SalesDetail salesDetail);

        void StockMaintain(DateTime dateTime, PurchaseDetail purchaseDetail);
        void AddStockDetail(string remarks, PurchaseDetail purchaseDetail);
    }
}
