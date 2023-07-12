using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace TodoList.Models
{
    public class Todo
    {
        [Required]
        [Key]
        public int ToDoId { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Description { get; set; }
        [Required]
        public DateTime CreatedDate { get; set;}
        public DateTime UpdatedDate { get; set;}

       
    }
    
}
