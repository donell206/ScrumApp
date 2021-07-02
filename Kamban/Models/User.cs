using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kamban.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
       
        [ForeignKey("ScrumTaskId")]
        public ICollection<ScrumTask> ScrumTasks { get; set; }
    }
}
