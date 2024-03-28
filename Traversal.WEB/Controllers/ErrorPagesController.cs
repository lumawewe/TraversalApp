using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Traversal.WEB.Controllers
{
    public class ErrorPagesController : Controller
    {
        [AllowAnonymous]
        public IActionResult Error404(int code)
        {

            return View();
        }
    }
}
