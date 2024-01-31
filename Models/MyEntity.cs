using System.ComponentModel.DataAnnotations;

namespace MyCRUDProject.Models
{
    public class MyEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
