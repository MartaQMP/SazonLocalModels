using System;
using System.Collections.Generic;
using System.Text;

namespace SazonLocalModels.Dto
{
    public class UsuarioLogin
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int IdRol { get; set; }
    }
}
