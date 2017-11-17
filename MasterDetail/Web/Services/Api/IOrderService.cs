
//------------------
// auto-generated
//------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  Web.ViewModel;

namespace Web.Services.Api
{
    public interface IOrderService
    {
        IEnumerable<OrderViewModel> GetDataList();
        OrderDetailViewModel GetDetail(string Id,out string errMsg);
        Boolean UpdateDetail(OrderDetailViewModel model, out string errMsg);
    }
}
