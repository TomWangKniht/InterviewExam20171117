using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.ViewModel
{
    public class OrderDetailViewModel
    {
        public string ID { get; set; }
        public string UnitPrice { get; set; }
        public string Quantity { get; set; }
        public string Discount { get; set; }
        public string ProductName { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public string ProductUnitPrice { get; set; }
        public string UnitsInStock { get; set; }
        public string UnitsOnOrder { get; set; }
        public string ReorderLevel { get; set; }
        public string Discontinued { get; set; }
    }
}