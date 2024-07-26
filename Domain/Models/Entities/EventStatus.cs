using System.ComponentModel.DataAnnotations;

namespace Domain.models.entities
{
    public class EventStatus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
