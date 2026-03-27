using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("VALIDACIONES")]
    public class Validacion
    {
        [Key]
        [Column("ID_VALIDACION")]
        public int IdValidacion { get; set; }

        [Column("ESTADO")]
        public string Estado { get; set; }
    }
}
