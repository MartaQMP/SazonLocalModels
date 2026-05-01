using SazonLocalModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SazonLocalModels.Dto
{
    public class MensajeDto
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string TipoConsulta { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
    }
}
