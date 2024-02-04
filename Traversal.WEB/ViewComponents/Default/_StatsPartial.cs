using Microsoft.AspNetCore.Mvc;

namespace Traversal.WEB.ViewComponents.Default
{
    public class _StatsPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
