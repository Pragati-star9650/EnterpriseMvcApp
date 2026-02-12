using EnterpriseMvcApp.Interfaces;
using EnterpriseMvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseMvcApp.Controllers
{
        public class AccountController(IUserService userService) : Controller
        {
            private readonly IUserService _userService = userService;

        // STEP A: Show Login Page
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // STEP B: Handle Login POST
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            // 1. Validate input
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // 2. Call service to validate user
            var user = _userService.ValidateUser(
                model.UserName,
                model.Password
            );

            // 3. If login fails
            if (user == null)
            {
                ViewBag.Error = "Invalid username or password";
                return View(model);
            }

            // 4. Login success → save session
            HttpContext.Session.SetString("UserName", user.UserName);

            // 5. Redirect to dashboard
            return RedirectToAction("Index", "Dashboard");
        }

        // STEP C: Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}