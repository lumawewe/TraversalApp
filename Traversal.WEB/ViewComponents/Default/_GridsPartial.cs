using Microsoft.AspNetCore.Mvc;

namespace Traversal.WEB.ViewComponents.Default
{
    public class _GridsPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
