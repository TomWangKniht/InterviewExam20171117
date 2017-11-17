using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.ViewModel
{
    public class OrderListViewModel : PagerModel
    {
        public IPagedList<OrderViewModel> DataList { set; get; }
    }
}