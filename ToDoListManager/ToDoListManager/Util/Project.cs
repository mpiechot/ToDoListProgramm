using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListManager.Util
{
    public class Project
    {
        public string name { get; private set; }

        private List<Task> newTasks;
        private List<Task> inProgressTasks;
        private List<Task> doneTasks;

        public Project(string name)
        {
            this.name = name;

            newTasks = new List<Task>();
            inProgressTasks = new List<Task>();
            doneTasks = new List<Task>();
        }

        public List<Task> GetNewTasks()
        {
            return newTasks;
        }
        public List<Task> GetInProgressTasks()
        {
            return inProgressTasks;
        }
        public List<Task> GetDoneTasks()
        {
            return doneTasks;
        }
    }
}
