using Microsoft.AspNetCore.Mvc;

namespace Traversal.WEB.ViewComponents.AdminDashboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
