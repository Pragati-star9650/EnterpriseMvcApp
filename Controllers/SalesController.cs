using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Quotations()
        {
            var docs = GetSampleDocuments("Quotation");
            return View(docs);
        }

        public IActionResult Orders()
        {
            var docs = GetSampleDocuments("Order");
            return View(docs);
        }

        public IActionResult ARInvoices()
        {
            var docs = GetSampleDocuments("A/R Invoice");
            return View(docs);
        }

        public IActionResult BlanketAgreement()
        {
            return View();
        }

        public IActionResult Delivery()
        {
            return View();
        }

        public IActionResult ReturnRequest()
        {
            return View();
        }

        public IActionResult Return()
        {
            return View();
        }

        public IActionResult ARDownPaymentRequest()
        {
            return View();
        }

        public IActionResult ARDownPaymentInvoice()
        {
            return View();
        }

        public IActionResult ARInvoicePayment()
        {
            return View();
        }

        public IActionResult ARCreditMemo()
        {
            return View();
        }

        public IActionResult DocumentGenerationWizard()
        {
            return View();
        }

        public IActionResult RecurringTransactions()
        {
            return View();
        }

        private List<SalesDocumentViewModel> GetSampleDocuments(string docType)
        {
            var list = new List<SalesDocumentViewModel>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(new SalesDocumentViewModel
                {
                    DocNumber = $"{docType[..1]}{1000 + i}",
                    DocDate = DateTime.Today.AddDays(-i),
                    BusinessPartnerCode = $"C{i:000}",
                    BusinessPartnerName = $"Customer {i}",
                    Total = 1000m * i,
                    Status = i % 2 == 0 ? "Open" : "Closed",
                    DocType = docType
                });
            }
            return list;
        }
    }

    public class SalesDocumentViewModel
    {
        public string DocNumber { get; set; } = string.Empty;
        public DateTime DocDate { get; set; }
        public string BusinessPartnerCode { get; set; } = string.Empty;
        public string BusinessPartnerName { get; set; } = string.Empty;
        public decimal Total { get; set; }
        public string Status { get; set; } = string.Empty;
        public string DocType { get; set; } = string.Empty;
    }
}

