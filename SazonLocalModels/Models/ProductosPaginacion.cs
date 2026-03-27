namespace SazonLocalModels.Models
{
    public class ProductosPaginacion
    {
        public List<Producto> Productos { get; set; }
        public int TotalProductos { get; set; }
        public int NumeroRegistros { get; set; }
    }
}
