using MvcPaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Services.Api;
using Web.Services.Fake;
using Web.Services.Impl;
using Web.ViewModel;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        IOrderService service = new OrderServiceImpl();
        // GET: Demo
        public ActionResult Index(OrderListViewModel model)
        {
            model.page = model.page == 0 ? 1 : model.page;
            int currentPageIndex = model.page.HasValue ? model.page.Value - 1 : 0;
            model.DataList = service.GetDataList().ToPagedList(currentPageIndex,10);
            return View(model);
        }

        public ActionResult ShowDetail(string Id)
        {
            var errMsg = String.Empty;
            var result = service.GetDetail(Id, out errMsg);
            ViewBag.ErrMsg = errMsg;
            return PartialView("_Detail", result);
        }

        public ActionResult UpdateDetail(OrderDetailViewModel model)
        {
            var errMsg = String.Empty;
            var result = service.UpdateDetail(model, out errMsg);
            ViewBag.ErrMsg = errMsg;
            return Json(new { message = errMsg, success = result });
        }
    }
}

