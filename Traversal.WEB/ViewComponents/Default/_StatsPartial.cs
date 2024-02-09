using Microsoft.AspNetCore.Mvc;
using Traversal.Repository.Concrete;

namespace Traversal.WEB.ViewComponents.Default
{
    public class _StatsPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";
            return View(); 
        }

    }
}
