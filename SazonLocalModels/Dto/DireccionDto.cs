namespace SazonLocalModels.Dto
{
    public class DireccionDto
    {
        public string? NombreEtiqueta { get; set; }
        public string CalleNumero { get; set; }
        public string? Piso { get; set; }
        public string? Puerta { get; set; }
        public string CodigoPostal { get; set; }
        public string Municipio { get; set; }
        public string Provincia { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public bool EsPrincipal { get; set; }
        public string? NotasAdicionales { get; set; }
    }
}
