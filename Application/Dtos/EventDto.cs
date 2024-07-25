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
        public int IdEtat { get; set; }
        public int IdOrganisateur { get; set; }
        public string Libelle { get; set; }
        public string Lieu { get; set; }

        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
    }
}
