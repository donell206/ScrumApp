using Microsoft.AspNetCore.Http;
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
    public class ScrumTaskController : Controller
    {
        private IRepository _repository;
        public ScrumTaskController(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<IActionResult> Index(int user)
        {
            ScrumBoard board = new ScrumBoard();
            board.User = user;
            board.NotCheckedOutTasks = await _repository.SelectAll<ScrumTask>(x => x.User, x => x.Category == Category.NotCheckedOut);
            board.CheckedOutTasks = await _repository.SelectAll<ScrumTask>(x => x.User, x => x.Category == Category.CheckedOut);
            board.DoneTasks = await _repository.SelectAll<ScrumTask>(x => x.User, x => x.Category == Category.Done);
            return View(board);
        }

        public async Task<IActionResult> Update(int id, string cat)
        {
            var task = await _repository.SelectById<ScrumTask>(id);
            switch (cat)
            {
                case "notchecked":
                    task.Category = Category.NotCheckedOut;
                    break;
                case "checked":
                    task.Category = Category.CheckedOut;
                    break;
                case "done":
                    task.Category = Category.Done;
                    break;
                default:
                    break;
            }
            await _repository.UpdateAsync(task);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Create(ScrumTask task, int userid)
        {
            task.UserId = userid;
            await _repository.CreateAsync<ScrumTask>(task);
            return RedirectToAction("Index");
        }
    }
}
