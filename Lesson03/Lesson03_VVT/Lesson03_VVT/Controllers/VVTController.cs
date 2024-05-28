using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson03_VVT.Controllers
{
    public class VVTController : Controller
    {
        // GET: VVT
        public ActionResult Index()
        {
            // Du lieu tu ViewData
            ViewData["msg"] = "ViewData - Vu Van Tuan";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");
            return View();
        }
        public ActionResult StudentList() 
        {
            // Sử Dụng ViewBag
            // Lưu Giá Trị đơn 
            ViewBag.titleName = "Danh Sách Học Viên - Vũ Văn Tuấn ";

            // Giá trị 1 tập hợp 
            string[] names = { "Vũ Văn Tuấn", "Tuấn Văn Vũ", "Văn Tuấn Vũ" };
            ViewBag.List = names;

            // Giá trị là 1 đối tượng 
            var obj = new
            {
                ID = 100,
                Name = "Tuấn",
                Age = 20,
            };
            ViewBag.Student= obj;
            return View();
        }
        public ActionResult Insert() 
        {
            return View("AddStudent");
        }
    }
}