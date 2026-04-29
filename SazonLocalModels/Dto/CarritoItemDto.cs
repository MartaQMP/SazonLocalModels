using SazonLocalModels.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Dto
{
    public class CarritoItemDto
    {
        public int Cantidad { get; set; }
        public int IdProducto { get; set; }
    }
}
