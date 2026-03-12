using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PurchaseOrders()
        {
            var docs = GetSampleDocuments("Purchase Order");
            return View(docs);
        }

        public IActionResult APInvoices()
        {
            var docs = GetSampleDocuments("A/P Invoice");
            return View(docs);
        }
        
        public IActionResult PurchaseRequest()
        {
            return View();
        }

        public IActionResult PurchaseQuotation()
        {
            return View();
        }

        public IActionResult GoodsReceiptPO()
        {
            return View();
        }

        public IActionResult APCreditMemo()
        {
            return View();
        }

        private List<PurchaseDocumentViewModel> GetSampleDocuments(string docType)
        {
            var list = new List<PurchaseDocumentViewModel>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(new PurchaseDocumentViewModel
                {
                    DocNumber = $"{docType[..1]}{2000 + i}",
                    DocDate = DateTime.Today.AddDays(-i),
                    VendorCode = $"V{i:000}",
                    VendorName = $"Vendor {i}",
                    Total = 800m * i,
                    Status = i % 2 == 0 ? "Open" : "Closed",
                    DocType = docType
                });
            }
            return list;
        }
    }

    public class PurchaseDocumentViewModel
    {
        public string DocNumber { get; set; } = string.Empty;
        public DateTime DocDate { get; set; }
        public string VendorCode { get; set; } = string.Empty;
        public string VendorName { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public string Status { get; set; } = string.Empty;
        public string DocType { get; set; } = string.Empty;
    }
}

