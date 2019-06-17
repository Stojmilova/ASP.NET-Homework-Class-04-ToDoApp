using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoTasks.Models;
using ToDoTasks.Models.DomainModels;
using ToDoTasks.Models.Enums;
using ToDoTasks.Models.ViewModels;

namespace ToDoTasks.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult NotDoneTasks(int? id)
        {
            User user = Db._usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult InProgressTasks(int? id)
        {
            User user = Db._usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult DoneTasks(int? id)
        {
            User user = Db._usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult UserStatistics(int? id)
        {
            User user = Db._usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpGet("AddNewTask")]
        public IActionResult AddNewTask(string error)
        {
            ViewBag.Error = error == null ? "" : error;
            TasksViewModel model = new TasksViewModel();
            return View(model);
        }

        [HttpPost("AddNewTask")]
        public IActionResult AddNewTask(TasksViewModel model)
        {
            ToDoTask task = new ToDoTask()
            {

                Id = Db.TaskId,
                Title = model.Title,
                Description = model.Description,
                Priority = model.Priority,
                Status = model.Status,
                TaskType = model.TaskType,
            };
            Db.TaskId++;
            Db._tasksDb.Add(task);//Add task in Db._taskDb;

            SubTask subtask = new SubTask()
            {
                Id = Db.SubTaskId,
                Title = model.TitleSubTask,
                Description = model.DescriptionSubTask,
                Status = model.StatusSubTask,

            };
            Db.SubTaskId++;
            task.SubTasks.Add(subtask);//Add subtask in SubTasks-List of task;

            User user = Db._usersDb.FirstOrDefault(x => x.Id == 3);
            user.CreatedTasks.Add(task);//Add task to login user - Megan Morton;

            return View("_AddedTask");
        }

    }
}
