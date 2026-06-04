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



        // SECCION PRODUCTOS

        public DataTable ObtenerProductosGeneral()
        {
            return helper.ProductosGeneral();
        }

        public DataTable ObtenerProductosCategoria(string categoria)
        {
            return helper.ProductosCategoria(categoria);
        }

        public DataTable ObtenerProductoBusqueda(string busqueda)
        {
            return helper.ProductoBusqueda(busqueda);
        }

        public DataTable ObtenerProductoCategoriaCantidad()
        {
            return helper.ProductoCategoriaCantidad();
        }

        public DataTable ObtenerProductoDetalle(string id)
        {
            return helper.ProductoDetalle(id);
        }



        // SECCION PEDIDOS
        public DataTable ObtenerPedidosGeneral()
        {
            return helper.PedidosGeneral();
        }

        public DataTable ObtenerPedidosDeHoy()
        {
            return helper.PedidosDeHoy();
        }

        public DataTable ObtenerPedidosEstatus(string estatus)
        {
            return helper.PedidosEstatus(estatus);
        }

        public DataTable ObtenerPedidosTotalEstatus()
        {
            return helper.PedidosTotalEstatus();
        }

        public DataTable ObtenerPedidosDetalle(string id)
        {
            return helper.PedidosDetalle(id);
        }




        // SECCION REPARTIDORES
        public DataTable ObtenerRepartidoresGeneral()
        {
            return helper.RepartidoresGeneral();
        }

        public DataTable ObtenerRepartidoresDisponibilidad(string disponibilidad)
        {
            return helper.RepartidoresDisponibilidad(disponibilidad);
        }

        public DataTable ObtenerRepartidoresBusqueda(string nombre)
        {
            return helper.RepartidoresBusqueda(nombre);
        }

        public DataTable ObtenerRepartidoresPedidos()
        {
            return helper.RepartidoresPedidos();
        }

        public DataTable ObtenerRepartidoresDetalle(string id)
        {
            return helper.RepartidoresDetalle(id);
        }




        // SECCION CATEGORIAS
        public DataTable ObtenerCategoriasGeneral()
        {
            return helper.CategoriasGeneral();
        }

        public DataTable ObtenerCategoriasBusqueda(string nombre)
        {
            return helper.CategoriasBusqueda(nombre);
        }

        public DataTable ObtenerCategoriasCantidadProductos()
        {
            return helper.CategoriasCantidadProductos();
        }

        public DataTable ObtenerCategoriasDetalle(string id)
        {
            return helper.CategoriasDetalle(id);
        }

        public DataTable ObtenerCategoriasDisponibles()
        {
            return helper.CategoriasDisponibles();
        }





        // SECCION DETALLES PRODUCTOS
        public DataTable ObtenerDetallesGeneral()
        {
            return helper.DetallesGeneral();
        }

        public DataTable ObtenerDetallesTamano(string tamano)
        {
            return helper.DetallesTamano(tamano);
        }

        public DataTable ObtenerDetallesCantidad()
        {
            return helper.DetallesCantidad();
        }

        public DataTable ObtenerDetallesBusqueda(string producto)
        {
            return helper.DetallesBusqueda(producto);
        }

        public DataTable ObtenerDetallesRegistro(string id)
        {
            return helper.DetallesRegistro(id);
        }

    }
}
