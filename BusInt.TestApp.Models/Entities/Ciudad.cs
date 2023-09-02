using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusInt.TestApp.Models.Entities
{
    [Table("")]
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        public string DianCode { get; set; }
        public string DianName { get; set; }
        public string DianDepartmentName { get; set; }
        public string DepartmentCode { get; set; }
    }
}
