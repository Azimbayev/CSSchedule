using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSSchedule.Data;
using CSSchedule.Models.Users;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CSSchedule.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsersContext _dbContext;

        public UsersController(UsersContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _dbContext.Users.ToListAsync();
            return View(movies);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(User user)
        {
            _dbContext.Users.Add(user);
            await _dbContext.SaveChangesAsync();

            var movies = await _dbContext.Users.ToListAsync();

            return View("Index", movies);
        }
    }
}