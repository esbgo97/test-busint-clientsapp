using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusInt.TestApp.Models.Entities
{
    [Table("dian-ciudades")]
    public class Ciudad
    {
        [Key, Column("codigoDian")]
        public string DianCode { get; set; }

        [Column("nomciuddian")]
        public string DianName { get; set; }

        [Column("nomdptodian")]
        public string DianDepartmentName { get; set; }
        
        [Column("CodDep")]
        public string DepartmentCode { get; set; }
    }
}
