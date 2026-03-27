using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("MENSAJES")]
    public class Mensaje
    {
        [Key]
        [Column("ID_MENSAJE")]
        public int IdMensaje { get; set; }

        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("TIPO_CONSULTA")]
        public string TipoConsulta { get; set; }

        [Column("ASUNTO")]
        public string Asunto { get; set; }

        [Column("CONTENIDO")]
        public string Contenido { get; set; }

        [Column("FECHA_ENVIO")]
        public DateTime FechaEnvio { get; set; }

        [Column("ES_LEIDO")]
        public bool EsLeido { get; set; }

        [Column("ES_RESPONDIDO")]
        public bool EsRespondido { get; set; }

        [ForeignKey("IdUsuario")]
        public virtual Usuario Usuario { get; set; }
    }
}
