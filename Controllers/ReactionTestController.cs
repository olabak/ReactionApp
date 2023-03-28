using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using ReactionTimeApp.Data;
using ReactionTimeApp.Models;

namespace ReactionTimeApp.Controllers
{
    public class ReactionTestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<HomeController> _logger;

        public ReactionTestController(ApplicationDbContext context, UserManager<ApplicationUser> userManager, ILogger<HomeController> logger)
        {
            _context = context;
            _userManager = userManager;
            _logger = logger;
        }

      
        public async Task<IActionResult> memory()
        {
            return View(await _context.ReactionTests.ToListAsync());
        }
        public async Task<IActionResult> levelEasy()
        {
            return View(await _context.ReactionTests.ToListAsync());
        }
        public async Task<IActionResult> levelMedium()
        {
            return View(await _context.ReactionTests.ToListAsync());
        }
        public async Task<IActionResult> levelHard()
        {
            return View(await _context.ReactionTests.ToListAsync());
        }
        public async Task<IActionResult> mediumShapes()
        {
            return View(await _context.ReactionTests.ToListAsync());
        } 
        public async Task<IActionResult> tinyShapes()
        {
            return View(await _context.ReactionTests.ToListAsync());
        }
        public async Task<IActionResult> bigGreenBox()
        {

            return View(await _context.ReactionTests.ToListAsync());
        }

       
        private bool ReactionTestExists(string id)
        {
            return _context.ReactionTests.Any(e => e.Id == id);
        }

        [HttpPost]
        [Route("AddTimeSpan")]
        [Authorize]
        public async Task<IActionResult> AddRecordToReactionTest(int span, string testName, int userAge, string userDevice)
        {

            AddRecordToReactionTestModel model = new AddRecordToReactionTestModel() { span = span, testName = testName, userAge=userAge, userDevice = userDevice };
            
            var CurrentUser = await _userManager.GetUserAsync(User);
            
            if (model == null)
                return BadRequest("Model niepoprawny");



            int seconds = span / 1000;
            int miliseconds = span - (seconds * 1000);
            int minutes = seconds / 60;
            seconds = seconds - (minutes * 60);
            int hours = minutes/60;
            minutes = minutes - (hours * 60);
            int days = hours / 24;

          
            TimeSpan timespan = new TimeSpan(days, hours, minutes, seconds, miliseconds);

            ReactionTest reactionTest = new ReactionTest()
            {
                Id = Guid.NewGuid().ToString(),
                ApplicationUserId = CurrentUser.Id,
                ReactionTime = timespan,
                Name = model.testName,
                UserAge = model.userAge,
                UserDevice = model.userDevice
            };
            await _context.ReactionTests.AddAsync(reactionTest);
            await _context.SaveChangesAsync();

            return Ok(JsonConvert.SerializeObject(new
            {
                Success = true
            }));
        }
    }
}
