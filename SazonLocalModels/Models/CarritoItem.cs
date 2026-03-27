using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("CARRITO_ITEMS")]
    public class CarritoItem
    {
        [Key]
        [Column("ID_CARRITO_ITEM")]
        public int IdCarrito { get; set; }

        [Column("CANTIDAD")]
        public int Cantidad { get; set; }

        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }

        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }

        [ForeignKey("IdProducto")]
        public virtual Producto Producto { get; set; }
    }
}
