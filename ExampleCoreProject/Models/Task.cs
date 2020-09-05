using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleCoreProject.Models
{
    public class Task
    {
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskSign { get; set; }
        public DateTime TaskDate { get; set; }
        public DateTime CreDate { get; set; }
        public string CreUser { get; set; }
        public bool IsDraft { get; set; }
    }
}
