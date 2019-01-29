using InsuranceQuote.Models;
using InsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuote.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                var quotes = (from d in db.Drivers
                              join c in db.Cars on d.Id equals c.DriverId
                              select new
                              {
                                  d.FirstName,
                                  d.LastName,
                                  d.DOB,
                                  d.Email,
                                  d.DUI,
                                  d.SpeedTickets,
                                  c.CarYear,
                                  c.CarMake,
                                  c.CarModel,
                                  c.CvgType,
                                  c.Quote
                              }).ToList();

                var quoteVms = new List<QuoteVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new QuoteVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    string birthday = quote.DOB.ToString();
                    DateTime datetime =Convert.ToDateTime(birthday);
                    quoteVm.DOB = datetime.ToShortDateString();
                    quoteVm.Email = quote.Email;
                    quoteVm.DUI = quote.DUI;
                    quoteVm.SpeedTickets = quote.SpeedTickets;
                    quoteVm.CarYear = quote.CarYear;
                    quoteVm.CarMake = quote.CarMake;
                    quoteVm.CarModel = quote.CarModel;
                    quoteVm.CvgType = quote.CvgType;
                    quoteVm.Quote = Convert.ToDecimal(quote.Quote);
                    quoteVms.Add(quoteVm);
                }
                return View(quoteVms);
            }
        }
    }
}