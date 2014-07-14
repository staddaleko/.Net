using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using S1.Models;

namespace S1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View("Index");
        }
        public ActionResult Create_A()
        {
            return View("Create_A");
        }
        [HttpPost]
        public ActionResult Create_A(Autor A)
        {
            var db = new MyDataContext();
            db.Autorzy.Add(A);
            db.SaveChanges();
            return View("Create_A");
        }

        public ActionResult Autorzy()
        {
            return View("Autorzy");
        }

        public ActionResult Detale_Autora(int id_a)
        {
            return View("Detale_Autora");
        }

        public ActionResult Edit_A(int id_a)
        {
            return View("Edit_A");
        }

        public ActionResult Delete_A(int id_a)
        {
            return View("Delete_A");
        }
    }
}
