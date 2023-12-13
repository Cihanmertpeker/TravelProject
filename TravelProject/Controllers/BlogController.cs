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
        BlogComment bc = new BlogComment();
        // GET: Blog
        public ActionResult Index()
        {
            bc.Value1 = context.Blogs.ToList();
            // var blogs = context.Blogs.ToList();
            bc.Value3 = context.Blogs.OrderByDescending(x => x.Date).Take(3).ToList();
            return View(bc);
        }



        public ActionResult BlogDetail(int id)
        {

            // var findBlog = context.Blogs.Where(x=>x.Id==id).ToList();
            bc.Value1 = context.Blogs.Where(x => x.Id == id).ToList();

            bc.Value2 = context.Comments.Where(x => x.BlogId == id).ToList();

            return View(bc);
        }

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.BlogId = id;
            return PartialView();
        }


        [HttpPost]
        public PartialViewResult AddComment(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return PartialView();
        }       

    }
}