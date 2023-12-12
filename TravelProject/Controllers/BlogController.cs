using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class BlogController : Controller
    {
        Context context = new Context();

        // GET: Blog
        public ActionResult Index()
        {
            var blogs = context.Blogs.ToList();

            return View(blogs);
        }
    }
}