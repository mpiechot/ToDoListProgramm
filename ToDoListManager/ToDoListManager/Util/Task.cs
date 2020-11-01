using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListManager.Util
{
    public enum TaskPriority
    {
        HIGH,
        NORMAL,
        LOW
    }
    public class Task
    {
        public string task { get; private set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public TaskPriority priority { get; set; }

        public Task(string task)
        {
            this.task = task;
        }
    }
}
