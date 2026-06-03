using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Starducks.Modelo;

namespace Starducks.Controlador
{
    internal class ReporteController
    {
        ReporteHelper helper = new ReporteHelper();

        public DataTable ObtenerUsuarios()
        {
            return helper.UsariosGeneral();
        }

        public DataTable ObtenerUsuariosRol(string rol)
        {
            return helper.UsuariosRol(rol);
        }

        public DataTable ObtenerUsuariosBusqueda(string busqueda)
        {
            return helper.UsuariosBusqueda(busqueda);
        }

        public DataTable ObtenerUsuariosCantidadRol()
        {
            return helper.UsuariosCantidadRol();
        }

        public DataTable ObtenerUsuariosDetalle(string id)
        {
            return helper.UsuariosDetalle(id);
        }
    }
}
