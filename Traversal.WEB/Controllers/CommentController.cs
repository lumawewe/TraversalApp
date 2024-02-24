using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Concrete;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.State = true;
            p.Id = 1;
            commentManager.TAdd(p);
            return RedirectToAction("Index" , "Destination");
        }
    }
}
