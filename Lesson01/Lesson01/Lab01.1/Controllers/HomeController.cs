using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01._1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Sử dụng ViewBag để truyền dữ liệu vào View
            ViewBag.message="Chào Mừng Bạn Đến Với ASP.NET MVC 5";  
            return View();
        }
        public ActionResult About()
        {
            ViewBag.message = "Đây là Trang About";
            return View();
        }
    }
}