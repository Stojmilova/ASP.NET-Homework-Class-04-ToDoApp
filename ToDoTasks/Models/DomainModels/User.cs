using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTasks.Models.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public decimal AverageFreeTime { get; set; }
        public List<ToDoTask> CreatedTasks { get; set; }
        public string Email { get; set; }       

        public User()
        {
            CreatedTasks = new List<ToDoTask>();
        }
    }
}
