using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceQuote.ViewModels
{
    public class QuoteDataVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        //public Nullable<System.DateTime> DOB { get; set; }
        public string DUI { get; set; }
        public Nullable<int> SpeedTickets { get; set; }
        public Nullable<int> CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string CvgType { get; set; }
        public decimal Quote { get; set; }
    }
}