using SmartShop.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartShop.Web.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }

        

    }
}