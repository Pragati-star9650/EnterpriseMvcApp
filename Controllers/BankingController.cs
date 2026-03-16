using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace EnterpriseMvcApp.Controllers
{
    public class BankingController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Module"] = "Banking";
            ViewData["Category"] = "Payments";
            ViewData["Page"] = "Banking";

            return View();
        }

        public IActionResult IncomingPayments()
        {
            ViewData["Module"] = "Banking";
            ViewData["Category"] = "Payments";
            ViewData["Page"] = "Incoming Payments";

            var docs = GetSamplePayments("Incoming");
            return View(docs);
        }

        public IActionResult OutgoingPayments()
        {
            ViewData["Module"] = "Banking";
            ViewData["Category"] = "Payments";
            ViewData["Page"] = "Outgoing Payments";

            var docs = GetSamplePayments("Outgoing");
            return View(docs);
        }

        private List<BankingDocumentViewModel> GetSamplePayments(string direction)
        {
            var list = new List<BankingDocumentViewModel>();
            for (int i = 1; i <= 5; i++)
            {
                list.Add(new BankingDocumentViewModel
                {
                    DocNumber = $"{direction[..1]}P{3000 + i}",
                    DocDate = DateTime.Today.AddDays(-i),
                    PartnerCode = $"{(direction == "Incoming" ? "C" : "V")}{i:000}",
                    PartnerName = direction == "Incoming" ? $"Customer {i}" : $"Vendor {i}",
                    Amount = 500m * i,
                    Direction = direction,
                    Method = i % 2 == 0 ? "Bank Transfer" : "Cash"
                });
            }
            return list;
        }
    }

    public class BankingDocumentViewModel
    {
        public string DocNumber { get; set; } = string.Empty;
        public DateTime DocDate { get; set; }
        public string PartnerCode { get; set; } = string.Empty;
        public string PartnerName { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Direction { get; set; } = string.Empty;
        public string Method { get; set; } = string.Empty;
    }
}