using SazonLocalModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SazonLocalModels.Dto
{
    public class PagoDto
    {
        public string Pasarela { get; set; }
        public string MetodoPago { get; set; }
        public string? UltimosDigitosTarjeta { get; set; }
        public string EstadoPago { get; set; }
        public string? TransactionId { get; set; }
        public int IdPedido { get; set; }
        }
}
