using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Concrete;

namespace Traversal.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    [AllowAnonymous]
    public class ReservationsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ReservationsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult NewReservation()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewReservation(Reservation p)
        {
            return View();
        }

        public IActionResult MyCurrentReservation()
        {
            return View();

        }

        public IActionResult MyOldReservation()
        {
            return View();

        }

    }
}
