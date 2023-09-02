using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusInt.TestApp.Models.Entities
{
    [Table("maestro_paises")]
    public class Pais
    {
        [Key]
        public string Codpais { get; set; }

        public string? Cod { get; set; }

        public string? Nompais { get; set; }

        public bool? Inactivo { get; set; }
    }
}
