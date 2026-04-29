namespace SazonLocalModels.Dto
{
    public class UsuarioDto
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string? Imagen { get; set; }
        public string? Telefono { get; set; }
        public int IdRol { get; set; }
    }
}
