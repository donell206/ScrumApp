using Microsoft.AspNetCore.Mvc;
using Kamban.Interfaces;
using Kamban.Models;
using Kamban.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kamban.Controllers
{
    public class UserController : Controller
    {
        private IRepository _repository;
        public UserController(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            UserVM Thisusermodel = new UserVM();
            Thisusermodel.Users = await _repository.SelectAll<User>();
            return View(Thisusermodel);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (ModelState.IsValid)
            {
                await _repository.CreateAsync<User>(user);
            }
            return View(nameof(Index));
        }
    }
}
