using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Sales";

            return View();
        }

        public IActionResult Quotations()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Sales Quotation";

            var docs = GetSampleDocuments("Quotation");
            return View(docs);
        }

        public IActionResult Orders()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Sales Order";

            var docs = GetSampleDocuments("Order");
            return View(docs);
        }

        public IActionResult Delivery()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Delivery";

            var docs = GetSampleDocuments("Delivery");
            return View(docs);
        }

        public IActionResult ReturnRequest()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Return Request";

            var docs = GetSampleDocuments("ReturnRequest");
            return View(docs);
        }

        public IActionResult Return()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Return";

            var docs = GetSampleDocuments("Return");
            return View(docs);
        }

        public IActionResult ARDownPaymentRequest()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "A/R Down Payment Request";

            var docs = GetSampleDocuments("ARDownPaymentRequest");
            return View(docs);
        }

        public IActionResult ARDownPaymentInvoice()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "A/R Down Payment Invoice";

            var docs = GetSampleDocuments("ARDownPaymentInvoice");
            return View(docs);
        }

        public IActionResult ARInvoices()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "A/R Invoice";

            var docs = GetSampleDocuments("ARInvoice");
            return View(docs);
        }

        public IActionResult ARInvoicePayment()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "A/R Invoice + Payment";

            var docs = GetSampleDocuments("ARInvoicePayment");
            return View(docs);
        }

        public IActionResult ARCreditMemo()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "A/R Credit Memo";

            var docs = GetSampleDocuments("ARCreditMemo");
            return View(docs);
        }

        public IActionResult DocumentGenerationWizard()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Document Generation Wizard";

            var docs = GetSampleDocuments("DocumentGenerationWizard");
            return View(docs);
        }

        public IActionResult RecurringTransactions()
        {
            ViewData["Module"] = "Sales A/R";
            ViewData["ModuleController"] = "Sales";
            ViewData["Category"] = "Sales Documents";
            ViewData["Page"] = "Recurring Transactions";

            var docs = GetSampleDocuments("RecurringTransactions");
            return View(docs);
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