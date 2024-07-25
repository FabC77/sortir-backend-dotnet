using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.models.entities
{
    public class Sortie
    {
        public int Id { get; set; }
        public int IdEtat { get; set; }
        public int IdOrganisateur { get; set; }
        public string Libelle { get; set; }
        public string Lieu { get; set; }

        public DateTime DateDeb { get; set; }
        public DateTime DateFin { get; set; }
    }
}
