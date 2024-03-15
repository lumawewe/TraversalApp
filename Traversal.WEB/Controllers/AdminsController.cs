using Microsoft.AspNetCore.Mvc;

namespace Traversal.WEB.Controllers
{
    public class AdminsController : Controller
    {
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult AppBrandDemoPartial()
        {
            return PartialView();
        }

        public PartialViewResult MenuPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            return PartialView();
        }

        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }
    }
}
