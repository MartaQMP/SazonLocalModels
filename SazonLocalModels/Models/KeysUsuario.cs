using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("KEYS_USUARIOS")]
    public class KeysUsuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int IdUsuario { get; set; }

        [Column("SALT")]
        public byte[] Salt { get; set; }

        [Column("PASSWORD")]
        public byte[] Password { get; set; }
    }
}
