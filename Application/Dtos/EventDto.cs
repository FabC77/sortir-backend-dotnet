using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class EventDto
    {
        public int Id { get; init; }
        public int StatusId { get; set; }
        public int OrganizerId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime Deadline { get; set; }
    }
}
