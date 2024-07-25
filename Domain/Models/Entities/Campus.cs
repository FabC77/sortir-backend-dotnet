using System.ComponentModel.DataAnnotations;

namespace Domain.models.entities
{
    public class Campus
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

public ICollection<User> Students { get; set; }
    }
}