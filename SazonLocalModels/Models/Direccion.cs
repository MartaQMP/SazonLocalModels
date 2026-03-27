using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("DIRECCIONES")]
    public class Direccion
    {
        [Key]
        [Column("ID_DIRECCION")]
        public int IdDireccion { get; set; }

        [Column("NOMBRE_ETIQUETA")]
        public string? NombreEtiqueta { get; set; }

        [Column("CALLE_NUMERO")]
        public string CalleNumero { get; set; }

        [Column("PISO")]
        public string? Piso { get; set; }

        [Column("PUERTA")]
        public string? Puerta { get; set; }

        [Column("CODIGO_POSTAL")]
        public string CodigoPostal { get; set; }

        [Column("MUNICIPIO")]
        public string Municipio { get; set; }

        [Column("PROVINCIA")]
        public string Provincia { get; set; }

        [Column("LATITUD", TypeName = "decimal(10, 8)")]
        public decimal Latitud { get; set; } 

        [Column("LONGITUD", TypeName = "decimal(10, 8)")]
        public decimal Longitud { get; set; }

        [Column("ES_PRINCIPAL")]
        public bool EsPrincipal { get; set; }

        [Column("NOTAS_ADICIONALES")]
        public string? NotasAdicionales { get; set; }

        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        public virtual ICollection<Pedido> Pedidos { get; set; }
    }
}
