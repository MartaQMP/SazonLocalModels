using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("SUBCATEGORIAS")]
    public class Subcategoria
    {
        [Key]
        [Column("ID_SUBCATEGORIA")]
        public int IdSubcategoria { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DESCRIPCION")]
        public string? Descripcion { get; set; }

        [Column("IMAGEN")]
        public string Imagen { get; set; }

        [Column("ESTA_ACTIVA")]
        public bool EstaActiva { get; set; }

        [Column("ID_CATEGORIA")]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }
    }
}
