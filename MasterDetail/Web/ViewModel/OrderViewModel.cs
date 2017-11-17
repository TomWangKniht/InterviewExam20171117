using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.ViewModel
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string CustomerID { get; set; }
        public String EmployeeID { get; set; }
        public String OrderDate { get; set; }
        public String RequiredDate { get; set; }
        public String ShippedDate { get; set; }
        public String ShipVia { get; set; }
        public String Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
    }
}