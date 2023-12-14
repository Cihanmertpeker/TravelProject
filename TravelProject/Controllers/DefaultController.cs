using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class DefaultController : Controller
    {
        Context context = new Context();
  
        public ActionResult Index()
        {
         
            var values = context.Blogs.Take(10).OrderByDescending(x=>x.Date).ToList();
            return View(values);
        }


        public ActionResult Contact()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderBy(x => x.Id).Take(2).ToList(); ;
            
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var values = context.Blogs.OrderBy(x => x.Id).Skip<Blog>(2).Take(1).ToList();

            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var values = context.Blogs.Take(10).ToList(); ;

            return PartialView(values);
        }

        public PartialViewResult Partial4()
        {
            var values = context.Blogs.Take(3).OrderByDescending(x => x.Date).ToList(); ;

            return PartialView(values);
        }

        public PartialViewResult Partial5()
        {

            var values = context.Blogs.OrderBy(x => x.Id).Skip<Blog>(3).Take(3).ToList();
          //  var values = context.Blogs.Take(3).OrderBy (x =>x.Date).ToList();

            return PartialView(values);
        }

    }
}