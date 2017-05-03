using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using SalesTracker.Models;

namespace SalesTracker.Controllers
{
    public class UserController : Controller
    {
        private readonly SalesTrackerContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController (UserManager<User> userManager, SignInManager<User> signInManager, SalesTrackerContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
