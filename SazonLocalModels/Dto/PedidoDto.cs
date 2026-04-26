using SazonLocalModels.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Dto
{
    public class PedidoDto
    {
        public int IdUsuario { get; set; }
        public int IdDireccion { get; set; }
    }
}
