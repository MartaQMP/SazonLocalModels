using SazonLocalModels.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Dto
{
    public class ProductoDto
    {
        public string Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Imagen { get; set; }
        public decimal PrecioUnidad { get; set; }
        public int IdUnidadMedida { get; set; }
        public int Stock { get; set; }
        public bool EstaActivo { get; set; }
        public int IdFinca { get; set; }
        public int IdSubcategoria { get; set; }
        public int IdCategoria { get; set; }
    }
}
