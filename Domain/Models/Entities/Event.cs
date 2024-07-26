using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.models.entities
{
    public class Event
    {
        [Key]
        public long Id { get; set; }
        //TODO revoir implémentation enums
        public int StatusId { get; set; }
        [Required]
        public Guid OrganizerId { get; set; }
        public string Name { get; set; }
        public string Infos { get; set; }
        public long LocationId { get; set; }
        public Location Location { get; set; }
        public int CampusId { get; set; }
        public Campus Campus { get; set; }
        public DateTime StartDate { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime Deadline { get; set; }

        public ICollection<User> Members { get; set; }
    }
}
