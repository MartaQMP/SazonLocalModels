using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("FINCAS")]
    public class Finca
    {
        [Key]
        [Column("ID_FINCA")]
        public int IdFinca { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("MUNICIPIO")]
        public string Municipio { get; set; }

        [Column("PROVINCIA")]
        public string Provincia { get; set; }

        [Column("LATITUD", TypeName = "decimal(10, 8)")]
        public decimal Latitud { get; set; }

        [Column("LONGITUD", TypeName = "decimal(10, 8)")]
        public decimal Longitud { get; set; }

        [Column("ESTA_ACTIVA")]
        public bool EstaActiva { get; set; }

        [Column("ESTA_VALIDADA")]
        public int EstaValidada { get; set; }

        [Column("ID_USUARIO")]
        public int IdAgricultor { get; set; }

        [ForeignKey("IdAgricultor")]
        public virtual Usuario Agricultor { get; set; }

        [ForeignKey("EstaValidada")]
        public virtual Validacion Validacion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
