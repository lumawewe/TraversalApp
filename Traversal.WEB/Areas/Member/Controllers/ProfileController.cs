using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Traversal.Core.Concrete;
using Traversal.WEB.Models;

namespace Traversal.WEB.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller][action]")]
    [AllowAnonymous]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);

            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.UserName = values.UserName;
            userEditViewModel.ImageUrl = values.ImageUrl;
            userEditViewModel.Gender = values.Gender;
            userEditViewModel.PhoneNumber = values.PhoneNumber;

            return View(userEditViewModel);
        }



    }
}
