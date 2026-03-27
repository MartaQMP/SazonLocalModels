using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("USUARIOS")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("APELLIDOS")]
        public string Apellidos { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("CONTRASENA")]
        public string? Contrasena { get; set; }

        [Column("IMAGEN")]
        public string? Imagen { get; set; }
        
        [Column("TELEFONO")]
        public string? Telefono { get; set; }

        [Column("ESTA_ACTIVO")]
        public bool EstaActivo { get; set; }

        [Column("ID_ROL")]
        public int IdRol { get; set; }

        [ForeignKey("IdRol")]
        public virtual Rol Rol { get; set; }


        [ForeignKey("IdUsuario")]
        public virtual KeysUsuario Keys { get; set; }
        public virtual ICollection<Finca> Fincas { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }

    }
}
