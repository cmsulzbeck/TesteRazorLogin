using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login_MVC_.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Classification { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public DateTime LastPurchase { get; set; }
        public Seller Seller { get; set; }
    }
}