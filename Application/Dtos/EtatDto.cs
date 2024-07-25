using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public class EtatDto
    {
        public int Id { get; init; }
        public string Libelle { get; set; }
    }
}
