using Starducks.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starducks.Controlador
{
    public class RegistroController
    {
        internal bool RegistroUsuario(string text1, string text2, string text3, string text4, string text5, string rutaFoto)
        {
            throw new NotImplementedException();
        }

        public bool RegistrarUsuario(
             string nombre,
             string usuario,
             string password,
             string telefono,
             string direccion,
             string foto)
        {
            Usuario nuevoUsuario = new Usuario();

            nuevoUsuario.Nombre = nombre;
            nuevoUsuario.User = usuario;
            nuevoUsuario.Password = password;
            nuevoUsuario.Telefono = telefono;
            nuevoUsuario.Direccion = direccion;
            nuevoUsuario.Foto = foto;

            UsuarioDAO dao = new UsuarioDAO();

            return dao.Insertar(nuevoUsuario);
        }
    }
}
