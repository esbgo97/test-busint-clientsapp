using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BusInt.TestApp.Models.Entities
{
    [Table("Clients")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public string Document { get; set; }
        public string DocType { get; set; }        
        public string Names { get; set; }
        public string LastNames { get; set; }
        public DateTime Birth{ get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Country { get; set; }
        public string Address { get; set; }
        public string Neighbornhood { get; set; }
        public int CivilStatus { get; set; }
        public int NumChild { get; set; }
        public string Job { get; set; }

        public bool AcceptTerm { get; set; }
        public bool AcceptData { get; set; }
        public bool AcceptNotifications { get; set; }
    }
}
