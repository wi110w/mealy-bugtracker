using System;
using System.ComponentModel.DataAnnotations;

namespace MealyBT.Models
{
    public class Task
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Type { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Assignee { get; set; }
        public int Priority { get; set; }
        public string Status { get; set; }
        public string Tags { get; set; }
        public string Comments { get; set; }
    }
}