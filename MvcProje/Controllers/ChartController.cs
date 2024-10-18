using EntityLayer.Concrete;
using MvcProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryChart()
        {
            return Json(BlogList(), JsonRequestBehavior.AllowGet); 
            // allowget almaya izin ver
        } 

        public List<CategoryClass> BlogList()
        {
            List<CategoryClass> ct = new List<CategoryClass>();
            ct.Add(new CategoryClass()
            {
                CategoryName = "Yazılım",
                CategoryCount = 23,
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Tiyatro",
                CategoryCount = 2,
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Film",
                CategoryCount = 18,
            });
            ct.Add(new CategoryClass()
            {
                CategoryName = "Spor",
                CategoryCount = 17,
            });
            
            return ct;
        }
    }
}