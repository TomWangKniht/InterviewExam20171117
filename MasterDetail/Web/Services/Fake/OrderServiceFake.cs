//------------------
// auto-generated
//------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Services.Api;
using Web.ViewModel;

namespace Web.Services.Fake
{
    public class OrderServiceFake : IOrderService
    {
        public IEnumerable<OrderViewModel> GetDataList()
        {
            var result = new List<OrderViewModel>();
            for(int i = 0; i < 20; i++)
            {
				result.Add(new OrderViewModel { 
						Id = i,
						CustomerID = $"CustomerID{i}",
						EmployeeID = $"EmployeeID{i}",
						OrderDate = $"OrderDate{i}",
						RequiredDate = $"RequiredDate{i}",
						ShippedDate = $"ShippedDate{i}",
						ShipVia = $"ShipVia{i}",
						Freight = $"Freight{i}",
						ShipName = $"ShipName{i}",
						ShipAddress = $"ShipAddress{i}",
						ShipCity = $"ShipCity{i}",
						ShipRegion = $"ShipRegion{i}",
						ShipPostalCode = $"ShipPostalCode{i}",
						ShipCountry = $"ShipCountry{i}",
					});
            }
            return result;
        }

        public OrderDetailViewModel GetDetail(string Id,out string errMsg)
        {
            errMsg = String.Empty;
            return new OrderDetailViewModel
            {
						ID = "IDFake",
						UnitPrice = "UnitPriceFake",
						Quantity = "QuantityFake",
						Discount = "DiscountFake",
						ProductName = "ProductNameFake",
						SupplierID = "SupplierIDFake",
						CategoryID = "CategoryIDFake",
						QuantityPerUnit = "QuantityPerUnitFake",
						ProductUnitPrice = "ProductUnitPriceFake",
						UnitsInStock = "UnitsInStockFake",
						UnitsOnOrder = "UnitsOnOrderFake",
						ReorderLevel = "ReorderLevelFake",
						Discontinued = "DiscontinuedFake",
            };
        }

        public bool UpdateDetail(OrderDetailViewModel model,out string errMsg)
        {
            errMsg = String.Empty;
            return true;
        }
    }
}
