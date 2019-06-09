using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoTasks.Models.DomainModels
{
    public class SubTask
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public TypeStatusSubTask Status { get; set; }
        
    }
    public enum TypeStatusSubTask
    {
        Done,
        NotDone,
    }
}
