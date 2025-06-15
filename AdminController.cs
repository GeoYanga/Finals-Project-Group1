using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TaskTrackerWebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return Content("Admin Controller is working!");
        }

        public IActionResult Users()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
    }
}
