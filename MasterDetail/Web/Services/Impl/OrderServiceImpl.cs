using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;
using Web.Services.Api;
using Web.ViewModel;

namespace Web.Services.Impl
{
    public class OrderServiceImpl : IOrderService
    {
        NORTHWNDEntities db = new NORTHWNDEntities();
        public IEnumerable<OrderViewModel> GetDataList()
        {
            var queryResult = db.Orders.OrderByDescending(o=>o.OrderDate).Select(o => new OrderViewModel
            {
                Id = o.OrderID,
                CustomerID = o.CustomerID,
                EmployeeID = o.EmployeeID.ToString(),
                OrderDate = o.OrderDate==null?"": o.OrderDate.Value.ToString(),
                RequiredDate = o.RequiredDate == null ? "" : o.RequiredDate.Value.ToString(),
                ShippedDate = o.ShippedDate == null ? "" : o.ShippedDate.Value.ToString(),
                ShipVia = o.ShipVia.ToString(),
                Freight = o.Freight.ToString(),
                ShipName = o.ShipName,
                ShipAddress = o.ShipAddress,
                ShipCity = o.ShipCity,
                ShipRegion = o.ShipRegion,
                ShipPostalCode = o.ShipPostalCode,
                ShipCountry = o.ShipCountry,
            });
            
            return queryResult;
        }

        public OrderDetailViewModel GetDetail(string Id, out string errMsg)
        {
            var result = new OrderDetailViewModel();
            errMsg = String.Empty;
            try
            {
                var idVal = Int32.Parse(Id);
                var findData = db.Order_Details.Where(o => o.OrderID == idVal).First();
                result=new OrderDetailViewModel
                {
                    ID = findData.OrderID.ToString(),
                    UnitPrice = findData.UnitPrice.ToString(),
                    Quantity = findData.Quantity.ToString(),
                    Discount = findData.Discount.ToString(),
                    ProductName = findData.Products.ProductName.ToString(),
                    SupplierID = findData.Products.SupplierID.ToString(),
                    CategoryID = findData.Products.CategoryID.ToString(),
                    QuantityPerUnit = findData.Products.QuantityPerUnit.ToString(),
                    ProductUnitPrice = findData.Products.UnitPrice.ToString(),
                    UnitsInStock = findData.Products.UnitsInStock.ToString(),
                    UnitsOnOrder = findData.Products.UnitsOnOrder.ToString(),
                    ReorderLevel = findData.Products.ReorderLevel.ToString(),
                    Discontinued = findData.Products.Discontinued.ToString(),
                };
            }
            catch(Exception ex)
            {
                errMsg = ex.Message;
            }
            return result;
        }

        public bool UpdateDetail(OrderDetailViewModel model, out string errMsg)
        {
            errMsg = String.Empty;
            return true;
        }
    }
}