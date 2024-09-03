using System.ComponentModel.DataAnnotations;

namespace MVC_CRUD_EF_API.Models
{

    public class Student
    {
        public int id { get; set; }
        [Required]
        public string? name { get; set; }
        [Required]
        public string? gender { get; set; }
        [Required]
        public string? standard { get; set; }
        [Required]
        public int age { get; set; }
    }

}
