using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelBill.Models;
using System.Globalization;
using AdminTemp.Areas.GstBill.Models;

namespace AdminTemp.Areas.GstBill.Controllers
{
    public class ProductController : Controller
    {
        FinanceTrackerEntities db = new FinanceTrackerEntities();

        #region------------------------Dashboard-------------------------
        public ActionResult Index()
        {
            return View();
        }
        #endregion-------------------------------------------------------

    }
}