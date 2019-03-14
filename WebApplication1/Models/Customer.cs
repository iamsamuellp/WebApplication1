using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RZOsound.Models
{
    public class Customer
    {
        public string customerID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string streetAddress { get; set; }
        public string city{ get; set; }
        public string zipCode{ get; set; }
        public string areaCode{ get; set; }
        public string phoneNumber { get; set; }
    }
}
