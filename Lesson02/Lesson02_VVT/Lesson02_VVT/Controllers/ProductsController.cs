using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson02_VVT.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:port/products
        public ActionResult Index()
        {
            ViewBag.name = "Vũ Văn Tuấn - K22CNTT4 - 2210900132";
            return View();
        }

        public ActionResult About(int? id) 
        {
            ViewBag.id = id;
            return View();
        }

        public string GetName() 
        {
            return "Vũ Văn Tuấn - 2210900132";
        }

        public JsonResult ListName()
        {
            string[] names = { "Tuấn", "Tuấn", "Trinh", "Trường", "Quyến" };

            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}