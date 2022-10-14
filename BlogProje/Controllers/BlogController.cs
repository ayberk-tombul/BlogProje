using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProje.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogsListWithCategory();
            return View(values);
        }
        public IActionResult BlogReadAll(int id)
        {
            var values = bm.GetBlogByID(id);
            return View(values);
        }
    }
}
