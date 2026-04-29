using SazonLocalModels.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SazonLocalModels.Dto
{
    public class MensajeDto
    {
        public string TipoConsulta { get; set; }
        public string Asunto { get; set; }
        public string Contenido { get; set; }
    }
}
