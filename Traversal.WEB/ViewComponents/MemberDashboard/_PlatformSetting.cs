using Microsoft.AspNetCore.Mvc;
using Traversal.Service.Concrete;

namespace Traversal.WEB.ViewComponents.MemberDashboard
{
    public class _PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
           
        }
    }
}
