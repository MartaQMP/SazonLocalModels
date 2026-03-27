using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SazonLocalModels.Models
{
    [Table("PAGOS")]
    public class Pago
    {
        [Key]
        [Column("ID_PAGO")]
        public int IdPago { get; set; }

        [Column("PASARELA")]
        public string Pasarela { get; set; }

        [Column("METODO_PAGO")]
        public string MetodoPago { get; set; }

        [Column("ULTIMOS_DIGITOS_TARJETA")]
        public string? UltimosDigitosTarjeta { get; set; }

        [Column("ESTADO_PAGO")]
        public string EstadoPago { get; set; }

        [Column("TRANSACTION_ID")]
        public string? TransactionId { get; set; }

        [Column("FECHA_PAGO")]
        public DateTime FechaPago { get; set; } = DateTime.Now;

        [Column("ID_PEDIDO")]
        public int IdPedido { get; set; }

        [ForeignKey("IdPedido")]
        public virtual Pedido Pedido { get; set; }
    }
}
