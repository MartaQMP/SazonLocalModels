using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("PRODUCTOS")]
    public class Producto
    {
        [Key]
        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DESCRIPCION")]
        public string? Descripcion { get; set; }

        [Column("IMAGEN")]
        public string? Imagen { get; set; }

        [Column("PRECIO_UNIDAD", TypeName = "decimal(10, 2)")] 
        public decimal PrecioUnidad { get; set; }

        [Column("ID_UNIDAD_MEDIDA")]
        public int IdUnidadMedida { get; set; }

        [ForeignKey("IdUnidadMedida")]
        public virtual UnidadMedida UnidadMedida { get; set; }

        [Column("STOCK")]
        public int Stock { get; set; }

        [Column("ESTA_ACTIVO")]
        public bool EstaActivo { get; set; }

        [Column("ID_FINCA")]
        public int IdFinca { get; set; }

        [ForeignKey("IdFinca")]
        public virtual Finca Finca { get; set; }

        [Column("ID_SUBCATEGORIA")]
        public int IdSubcategoria { get; set; }

        [ForeignKey("IdSubcategoria")]
        public virtual Subcategoria Subcategoria { get; set; }

        [Column("ID_CATEGORIA")]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        public virtual ICollection<DetallePedido> DetallePedido { get; set; }

    }
}
