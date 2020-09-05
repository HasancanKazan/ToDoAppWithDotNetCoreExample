using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleCoreProject.Models
{
    public static class Repository
    {
        private static List<Task> _tasks = new List<Task>();

        public static List<Task> tasks
        {
            get { return _tasks; }
        }

        public static void AddTask(Task model)
        {
            _tasks.Add(model);
        }
    }
}
