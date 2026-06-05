using System;
using System.Collections.Generic;
using System.Text;

namespace Starducks.Modelo
{
    internal class Usuario
    {
        public int IdUsuario {  get; set; }
        public string Nombre { get; set; }
        public string User {  get; set; }
        public string Password { get; set; }
        public string Rol {  get; set; }
        public string Telefono { get; set; }

        public string Direccion { get; set; }

        public string Foto { get; set; }

        public int Activo { get; set; }

    }
}
