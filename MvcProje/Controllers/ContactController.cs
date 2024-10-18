using BussinessLayer.Concrete;
using BussinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());

        public ActionResult Index(string searchQuery = "")
        {
            var contactvalues = string.IsNullOrEmpty(searchQuery)
                ? cm.GetList()
                : cm.GetList().Where(x => x.UserName.Contains(searchQuery) || x.Subject.Contains(searchQuery)).ToList();

            ViewBag.SearchQuery = searchQuery;
            return View(contactvalues);
        }

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetByID(id);
            return View(contactvalues);
        }

        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }
    }

}