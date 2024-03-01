using Azure.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Traversal.Core.Concrete;
using Traversal.WEB.Models;

namespace Traversal.WEB.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserRegisterViewModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.Surname,
                Email = p.Email,
                UserName = p.UserName,
                Gender = p.Gender,
                ImageUrl = p.ImageUrl
                //şifreyi hashlenerek alıyoruz o yüzden yazmadık
            };

            if(p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser , p.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Login");
                }

                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("" , item.Description);
                    }
                }
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            if(ModelState.IsValid)
            {
                //ispersisten : kullanıcıyı hatırlasın olucak lockoutOnFailure : 5 kez yanlış girince kilitleme özelliği
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index" , "Default");
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
