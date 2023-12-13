using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelProject.Models.Classes;

namespace TravelProject.Controllers
{
    public class AdminController : Controller
    {
        Context Context = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var values =Context.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            Context.Blogs.Add(blog);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var deletedBlog = Context.Blogs.Find(id);
            Context.Blogs.Remove(deletedBlog);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult EditBlog(int id) 
        { 
            var blog = Context.Blogs.Find(id);
            return View("EditBlog",blog);
        }
        [HttpPost]
        public ActionResult EditBlog(Blog blog)
        {
            var updatedblog = Context.Blogs.Find(blog.Id);

            updatedblog.Description = blog.Description;
            updatedblog.Title = blog.Title;
            updatedblog.BlogImage = blog.BlogImage;
            updatedblog.Date = blog.Date;
            updatedblog.Id = blog.Id;
            Context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}