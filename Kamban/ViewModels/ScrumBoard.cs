using Kamban.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kamban.ViewModels
{
    public class ScrumBoard
    {
        public List<ScrumTask> NotCheckedOutTasks { get; set; }
        public List<ScrumTask> CheckedOutTasks { get; set; }
        public List<ScrumTask> DoneTasks { get; set; }
        public int User { get; set; }
        public ScrumTask Task { get; set; }
    }
}
