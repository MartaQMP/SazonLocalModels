using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("UNIDAD_MEDIDAS")]
    public class UnidadMedida
    {
        [Key]
        [Column("ID_UNIDAD_MEDIDA")]
        public int IdUnidadMedida { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("ESTA_ACTIVA")]
        public bool EstaActiva { get; set; }
    }
}
