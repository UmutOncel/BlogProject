﻿using BlogProject.DAL.Entities;
using BlogProject.DAL.ViewModels.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorizeController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public AuthorizeController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [AllowAnonymous]    //Authorize işleminden hariç tutmak için.
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginVM userLoginVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(userLoginVM.Email);
            if (user == null) 
            {
                ModelState.AddModelError("", "Email adresininiz veya şifreniz yanlıştır.");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, userLoginVM.Password, userLoginVM.RememberMe, false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Email adresininiz veya şifreniz yanlıştır.");
                return View();
            }

            return RedirectToAction("Index", "Home", new { Area = "" });
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout() 
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home", new { Area = "" });
        }


        [Authorize]
        [HttpGet]
        public async Task<IActionResult> AccessDenied()     //Rol bazlı erişim engeline takılırsak bu sayfaya yönlendirecek.
        {
            return View();
        }
    }
}
