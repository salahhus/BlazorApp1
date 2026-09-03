using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(30)]
        public string Lastname { get; set; } = string.Empty;

        [Required]
        [StringLength(40)]
        public string Occupation { get; set; } = string.Empty;

        [Required]
        public int Age { get; set; }
    }
}
