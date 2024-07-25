using System.ComponentModel.DataAnnotations;

namespace Domain.models.entities
{
    public class Location
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public long CityId {  get; set; }

        public ICollection<Event> Events { get; set; }

    }
}