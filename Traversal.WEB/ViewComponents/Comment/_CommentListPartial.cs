using Microsoft.AspNetCore.Mvc;
using Traversal.Repository.EntityFramework;
using Traversal.Service.Concrete;

namespace Traversal.WEB.ViewComponents.Comment
{
    public class _CommentListPartial : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}
