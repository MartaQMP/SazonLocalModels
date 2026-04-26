using System;
using System.Collections.Generic;
using System.Text;

namespace SazonLocalModels.Dto
{
    public class ProductoBuscadorDto
    {
        public string? Buscador { get; set; }
        public int? IdCategoria { get; set; }
        public int? IdSubcategoria { get; set; }
        public int? IdFinca { get; set; }
        public decimal? Precio { get; set; }
    }
}
