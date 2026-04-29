using System;
using System.Collections.Generic;
using System.Text;

namespace SazonLocalModels.Models
{
    public class AdminConfiguracionModels
    {
        public List<Categoria> Categorias { get; set; }
        public List<Subcategoria> Subcategorias { get; set; }
        public List<UnidadMedida> UnidadMedidas { get; set; }
    }
}
