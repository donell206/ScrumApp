using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kamban.Models
{
    public class ScrumTask
    {
        [Key]
        public int ScrumTaskId { get; set; }
        public Category Category { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
    }
    public enum Category
    {
        NotCheckedOut,
        CheckedOut,
        Done
    }
}
