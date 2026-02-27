using EnterpriseMvcApp.Data;
using EnterpriseMvcApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EnterpriseMvcApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        private void LoadServers()
        {
            try
            {
                ViewBag.ServerList = _context.Servers
                    .Where(s => s.ServerStatus == true)
                    .ToList();
            }
            catch
            {
                ViewBag.ServerList = new List<Server>();
                ViewBag.DbError = "Could not load server list. Check that the database is running and migrations are applied.";
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            LoadServers();
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult GetDatabases(int serverId)
        {
            var databases = _context.Databases
                                    .Where(d => d.ServerId == serverId && d.IsActive == true)
                                    .Select(d => new
                                    {
                                        databaseId = d.DatabaseId,
                                        databaseName = d.DatabaseName
                                    })
                                    .ToList();

            return Json(databases);
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            LoadServers();
            return View();
        }

        [HttpPost]
        public IActionResult Signup(SignupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadServers();
                return View(model);
            }

            int resolvedServerId = model.ServerId;
            int resolvedDatabaseId = model.DatabaseId;

            // Create new Server if requested
            if (model.ServerId == 0)
            {
                if (string.IsNullOrWhiteSpace(model.NewServerName))
                {
                    ViewBag.Error = "Please provide a server name for the new server.";
                    LoadServers();
                    return View(model);
                }

                var newServer = new Server
                {
                    ServerName = model.NewServerName.Trim(),
                    ServerStatus = true
                };
                _context.Servers.Add(newServer);
                _context.SaveChanges();
                resolvedServerId = newServer.ServerId;
            }

            // Create new Database if requested
            if (model.DatabaseId == 0)
            {
                if (string.IsNullOrWhiteSpace(model.NewDatabaseName))
                {
                    ViewBag.Error = "Please provide a database name for the new database.";
                    LoadServers();
                    return View(model);
                }

                var newDb = new Database
                {
                    ServerId = resolvedServerId,
                    DatabaseName = model.NewDatabaseName.Trim(),
                    DbUser = string.Empty,
                    DbPassword = string.Empty,
                    IsActive = true
                };
                _context.Databases.Add(newDb);
                _context.SaveChanges();
                resolvedDatabaseId = newDb.DatabaseId;
            }

            var existingUser = _context.UserMasters.FirstOrDefault(u => u.UserName == model.UserName);
            if (existingUser != null)
            {
                ViewBag.Error = "Username already exists.";
                LoadServers();
                return View(model);
            }

            var user = new UserMaster
            {
                UserName = model.UserName,
                Password = model.Password,
                IsActive = true
            };

            _context.UserMasters.Add(user);
            _context.SaveChanges();

            var access = new UserCompanyAccess
            {
                UserId = user.Id,
                ServerId = resolvedServerId,
                DatabaseId = resolvedDatabaseId
            };

            _context.UserCompanyAccess.Add(access);
            _context.SaveChanges();

            // Auto-login after successful signup
            HttpContext.Session.SetString("UserName", user.UserName);
            HttpContext.Session.SetInt32("ServerId", resolvedServerId);
            HttpContext.Session.SetInt32("DatabaseId", resolvedDatabaseId);
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                LoadServers();
                return View(model);
            }

            var user = _context.UserMasters.FirstOrDefault(u =>
                u.UserName == model.UserName &&
                u.Password == model.Password &&
                u.IsActive == true);

            if (user == null)
            {
                ViewBag.Error = "Invalid username or password";
                LoadServers();
                return View(model);
            }

            var hasAccess = _context.UserCompanyAccess.Any(x =>
                x.UserId == user.Id &&
                x.ServerId == model.ServerId &&
                x.DatabaseId == model.DatabaseId);

            if (!hasAccess)
            {
                ViewBag.Error = "You do not have access to this company.";
                LoadServers();
                return View(model);
            }

            HttpContext.Session.SetString("UserName", user.UserName);
            HttpContext.Session.SetInt32("ServerId", model.ServerId);
            HttpContext.Session.SetInt32("DatabaseId", model.DatabaseId);

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
