using Aplikacja.DataAcces;
using Aplikacja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplikacja.Controllers
{
    public class HomeController : Controller
    {
        private DataConext db = new DataConext();
        //DB database = new DB();
        
        public ActionResult Index()
        {
            User1 user = new User1 { id = 1, Email = "dwa@dw.pl"};
            db.users1.Add(user);
            db.SaveChanges();
            return View();
        }

        public ActionResult LoginPage()
        {
            //  ViewBag.Message = "Login Page";
            

            return View();
        }

        public ActionResult RegistryPage()
        {
         //   ViewBag.Message = "Register Page";

            return View();
        }

        public ActionResult RecipePage()
        {

            return View();
        }

        public ActionResult RecipePageList()
        {

            return View();
        }
    }
}