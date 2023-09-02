using System.ComponentModel.DataAnnotations;

namespace BusInt.TestApp.Models.Entities
{
    public class Pais
    {
        [Key]
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool Active { get; set; }
    }
}
