using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTasks.Models.DomainModels
{
    public class ToDoTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TypePriority Priority { get; set; }  
        public TypeStatus Status { get; set; }
        public TypeOfTask TaskType { get; set; }
        public List<SubTask> SubTasks { get; set; }

        public ToDoTask()
        {
            SubTasks = new List<SubTask>();
        }
    }

    public enum TypePriority
    {
        Important = 1,
        MediumImportance,
        NotImportant,

    }
    public enum TypeStatus
    {
        NotDone,
        InProgress,
        Done
    }
    public enum TypeOfTask
    {
        Work,
        Personal,
        Hobby
    }
}
