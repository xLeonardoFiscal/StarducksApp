using System;
using System.Collections.Generic;
using System.Text;

namespace Starducks.Modelo
{
    internal class Auditoria
    {
        public int IdAdmin { get; set; }

        public int IdUsuarioAfectado { get; set; }

        public string TablaAfectada { get; set; }

        public string Accion { get; set; }

        public string Descripcion { get; set; }
    }
}
