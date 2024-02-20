using Microsoft.AspNetCore.Mvc;
using Traversal.Service.Concrete;
using Traversal.WEB.ViewComponents.AddComment;

namespace Traversal.WEB.ViewComponents.Comment
{
    public class _CommentListPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
