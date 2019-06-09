using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoTasks.Models;
using ToDoTasks.Models.DomainModels;

namespace ToDoTasks.Controllers
{
    public class TaskController : Controller
    {
        public List<ToDoTask> _tasksDb;
        public List<SubTask> _subtasksDb;
        public List<User> _usersDb;

        public TaskController()
        {
            SubTask oneSubTask = new SubTask()
            {
                Title = "Invitation",
                Description = "Send invitations",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask twoSubTask = new SubTask()
            {
                Title = "Cake",
                Description = "Make the cake!",
                Status = TypeStatusSubTask.Done,
            };
            SubTask threeSubTask = new SubTask()
            {
                Title = "Tickets",
                Description = "Searching for flights",
                Status = TypeStatusSubTask.Done,
            };
            SubTask fourSubTask = new SubTask()
            {
                Title = "Picking the destination",
                Description = "Research hotels, tours, and attractions",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask fiveSubTask = new SubTask()
            {
                Title = "LayoutView",
                Description = "Create a layout with navigation for all views in application",
                Status = TypeStatusSubTask.Done,
            };
            SubTask sixSubTask = new SubTask()
            {
                Title = "First page",
                Description = "Create page which shown all tasks that are still not done",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask sevenSubTask = new SubTask()
            {
                Title = "Tripod",
                Description = "Bring a Tripod",
                Status = TypeStatusSubTask.Done,
            };
            SubTask eightSubTask = new SubTask()
            {
                Title = "Lens",
                Description = "Use the Right Lens",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask nineSubTask = new SubTask()
            {
                Title = "Design the a memorable logo",
                Description = "Make simple logo that all will actually remember.",
                Status = TypeStatusSubTask.Done,
            };
            SubTask tenSubTask = new SubTask()
            {
                Title = "Meeting",
                Description = "Meeting with the team about the ideas",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask elevenSubTask = new SubTask()
            {
                Title = "Better disign",
                Description = "Include bootstrap in project",
                Status = TypeStatusSubTask.NotDone,
            };
            SubTask twelveSubTask = new SubTask()
            {
                Title = "Buttons",
                Description = "Improved design of buttons",
                Status = TypeStatusSubTask.NotDone,
            };


            _subtasksDb = new List<SubTask>() { oneSubTask, twoSubTask, threeSubTask, fourSubTask, fiveSubTask, sixSubTask, sevenSubTask, eightSubTask, nineSubTask, tenSubTask, elevenSubTask, twelveSubTask };

            ToDoTask oneTask = new ToDoTask()
            {
               Title = "Create models and structure for the ToDo application",
               Description = "Application about done, not done, in progress Tasks and User statistics",
               Priority = TypePriority.MediumImportance,
               Status = TypeStatus.InProgress,
               TaskType = TypeOfTask.Work,             
            };
            oneTask.SubTasks.Add(fiveSubTask);
            oneTask.SubTasks.Add(sixSubTask);

            ToDoTask twoTask = new ToDoTask()
            {
                Title = "BirthdayParty",
                Description = "Shopping and decoration",
                Priority = TypePriority.Important,
                Status = TypeStatus.Done,
                TaskType = TypeOfTask.Personal,                
            };
            twoTask.SubTasks.Add(oneSubTask);
            twoTask.SubTasks.Add(twoSubTask);

            ToDoTask threeTask = new ToDoTask()
            {
                Title = "Travel",
                Description = "Organization of trip in Italy",
                Priority = TypePriority.NotImportant,
                Status = TypeStatus.NotDone,
                TaskType = TypeOfTask.Hobby,
            };
            threeTask.SubTasks.Add(threeSubTask);
            threeTask.SubTasks.Add(fourSubTask);

            ToDoTask fourTask = new ToDoTask()
            {
                Title = "Photo walk",
                Description = "Prepared for walk in nature",
                Priority = TypePriority.NotImportant,
                Status = TypeStatus.Done,
                TaskType = TypeOfTask.Hobby,
            };
            fourTask.SubTasks.Add(sevenSubTask);
            fourTask.SubTasks.Add(eightSubTask);

            ToDoTask fiveTask = new ToDoTask()
            {
                Title = "Logo",
                Description = "Design a new organization logo",
                Priority = TypePriority.MediumImportance,
                Status = TypeStatus.NotDone,
                TaskType = TypeOfTask.Work,
            };
            fiveTask.SubTasks.Add(nineSubTask);
            fiveTask.SubTasks.Add(tenSubTask);

            ToDoTask sixTask = new ToDoTask()
            {
                Title = "Drop down",
                Description = "Make drop down menus scrollable",
                Priority = TypePriority.Important,
                Status = TypeStatus.NotDone,
                TaskType = TypeOfTask.Work,
            };
            sixTask.SubTasks.Add(elevenSubTask);
            sixTask.SubTasks.Add(twelveSubTask);


            _tasksDb = new List<ToDoTask>() { oneTask, twoTask, threeTask, fourTask, fiveTask, sixTask };

            User oneUser = new User()
            {
                Id = 1,
                FirstName = "Anna",
                LastName ="Benton",
                Age = 28,
                AverageFreeTime= 2.5M,
            };
            oneUser.CreatedTasks.Add(oneTask);
            oneUser.CreatedTasks.Add(threeTask);
            oneUser.CreatedTasks.Add(fourTask);

            User twoUser = new User()
            {
                Id = 2,
                FirstName = "Smith",
                LastName = "Anderson",
                Age = 29,
                AverageFreeTime = 1.2M,
            };
            twoUser.CreatedTasks.Add(oneTask);
            twoUser.CreatedTasks.Add(twoTask);
            twoUser.CreatedTasks.Add(fiveTask);
            
            User threeUser = new User()
            {
                Id = 3,
                FirstName = "Megan",
                LastName = "Morton",
                Age = 30,
                AverageFreeTime = 3.7M,
            };
            threeUser.CreatedTasks.Add(oneTask);
            threeUser.CreatedTasks.Add(twoTask);
            threeUser.CreatedTasks.Add(threeTask);
            threeUser.CreatedTasks.Add(fiveTask);

            _usersDb = new List<User>() { oneUser, twoUser, threeUser };

        }

        public IActionResult NotDoneTasks(int? id)
        {
            User user = _usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult InProgressTasks(int? id)
        {
            User user = _usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult DoneTasks(int? id)
        {
            User user = _usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        public IActionResult UserStatistics(int? id)
        {
            User user = _usersDb.FirstOrDefault(x => x.Id == id);
            return View(user);
        }
        
    }
}
