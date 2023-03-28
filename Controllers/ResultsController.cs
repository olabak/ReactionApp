using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReactionTimeApp.Data;
using ReactionTimeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReactionTimeApp.Controllers
{
    [Authorize]
    public class ResultsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<HomeController> _logger;
        public ResultsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, ILogger<HomeController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }
        public IActionResult Result()
        {
            return View();
        }
        public IActionResult Easy()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var founded = _context.ReactionTests.Where(x => x.ApplicationUserId == id).ToList();
            var easy = founded.Where(x => x.Name == "Easy").OrderBy(x => x.ReactionTime).ToList();
            return View(easy);
        }
        public IActionResult Medium()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var founded = _context.ReactionTests.Where(x => x.ApplicationUserId == id).ToList();
            var easy = founded.Where(x => x.Name == "Medium").OrderBy(x => x.ReactionTime).ToList();
            return View(easy);
        }
        public IActionResult Hard()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var founded = _context.ReactionTests.Where(x => x.ApplicationUserId == id).ToList();
            var easy = founded.Where(x => x.Name == "Hard").OrderBy(x => x.ReactionTime).ToList();
            return View(easy);
        }
        public IActionResult TinyShapes()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var founded = _context.ReactionTests.Where(x => x.ApplicationUserId == id).ToList();
            var easy = founded.Where(x => x.Name == "Tine shapes").OrderBy(x => x.ReactionTime).ToList();
            return View(easy);
        }
        public IActionResult MediumShapes()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var founded = _context.ReactionTests.Where(x => x.ApplicationUserId == id).ToList();
            var easy = founded.Where(x => x.Name == "Medium shapes").OrderBy(x => x.ReactionTime).ToList();
            return View(easy);
        }
        public IActionResult BigGreenBox()
        {
            var id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var founded = _context.ReactionTests.Where(x => x.ApplicationUserId == id).ToList();
            var easy = founded.Where(x => x.Name == "Big green box").OrderBy(x => x.ReactionTime).ToList();
            return View(easy);
        }
    }
}
