using InsuranceQuote.Models;
using InsuranceQuote.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //Update Driver database with Driver info from form on Index View
        [HttpPost]
         public ActionResult InsQuote ( string firstName, string lastName, string dob, string email, string dui, int speedTickets,
                                                            int carYear, string carMake, string carModel, string cvgType)
        {
            string carmake = carMake.ToUpper();
            string carmodel = carModel.ToUpper();
            string cvgtype = cvgType.ToUpper();
            string dd = dui.ToUpper();
            int birthYear = DateTime.Parse(dob).Year;
            int birthMonth = DateTime.Parse(dob).Month;
            DateTime current = DateTime.Now;
            int currentYear = current.Year;
            int currentMonth = current.Month;

            

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                var quoteData = new QuoteDataVm();

                quoteData.FirstName = firstName;
                quoteData.LastName = lastName;
                quoteData.DOB = dob;
                quoteData.DUI = dd;
                quoteData.SpeedTickets = speedTickets;
                quoteData.CarYear = carYear;
                quoteData.CarMake = carMake;
                quoteData.CarModel = carModel;
                quoteData.CvgType = cvgType;

                double monthlyTotal = 50;

                if ((currentYear - birthYear == 18) && (currentMonth - birthMonth < 0))
                { 
                    monthlyTotal = monthlyTotal + 100;
                } else  if ((currentYear - birthYear == 25) && (currentMonth - birthMonth < 0))
                {
                    monthlyTotal = monthlyTotal + 25;
                } else if ((currentYear - birthYear == 100) && (currentMonth - birthMonth > 0))
                {
                    monthlyTotal = monthlyTotal + 25;
                }

                if ((carYear < 2000) || (carYear > 2015)) monthlyTotal = monthlyTotal + 25;

                if ((carmake == "PORSCHE") && (carmodel == "911 CARRERA"))
                {
                    monthlyTotal = monthlyTotal + 50;
                }
                else if (carmake == "PORSCHE")
                {
                    monthlyTotal = monthlyTotal + 25;
                };

                if (speedTickets > 0) monthlyTotal = monthlyTotal + (speedTickets * 10);

                if (dd == "YES") monthlyTotal = (monthlyTotal * 1.25);

                if (cvgtype == "FULL COVERAGE") monthlyTotal = (monthlyTotal * 1.5);

                quoteData.Quote = Convert.ToDecimal(monthlyTotal);

                using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
                {
                    var driver = new Driver();
                    var car = new Car();
                    driver.FirstName = firstName;
                    driver.LastName = lastName;
                    driver.DOB = Convert.ToDateTime(dob);
                    driver.Email = email;
                    driver.DUI = dd;
                    driver.SpeedTickets = speedTickets;              

                    db.Drivers.Add(driver);
                    db.SaveChanges();

                    car.DriverId = driver.Id;                  
                    car.CarYear = carYear;                    
                    car.CarMake = carmake;                   
                    car.CarModel = carmodel;                  
                    car.CvgType = cvgtype;
                    car.Quote = quoteData.Quote;

                    db.Cars.Add(car);
                    db.SaveChanges();
       
                }
                return View(quoteData);
            }
        }       
       
    }
}