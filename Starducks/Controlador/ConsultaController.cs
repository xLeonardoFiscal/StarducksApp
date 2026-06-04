using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Starducks.Modelo;

namespace Starducks.Controlador
{
    internal class ConsultaController
    {
        ConsultaHelper helper = new ConsultaHelper();

        // USUARIOS
        public DataTable ObtenerUsuarios(string nombre, string rol)
        {
            return helper.ConsultarUsuarios(nombre, rol);
        }

        // PRODUCTOS
        public DataTable ObtenerProductos(string nombre, string categoria)
        {
            return helper.ConsultarProductos(nombre, categoria);
        }
        
        // PEDIDOS
        public DataTable ObtenerPedidos(DateTime? fechaInicio, DateTime? fechaFin, string estatus)
        {
            return helper.ConsultarPedidos(fechaInicio, fechaFin, estatus);
        }

        // CATEGORIAS
        public DataTable ObtenerCategorias(string nombre)
        {
            return helper.ConsultarCategorias(nombre);
        }

        //REPARTIDORES
        public DataTable ObtenerRepartidores(string nombre, string disponible)
        {
            return helper.ConsultarRepartidores(nombre, disponible);
        }

        // DETALLES PRODUCTO
        public DataTable ObtenerDetalles(string producto, string tamano)
        {
            return helper.ConsultarDetalles(producto, tamano);
        }
    }
}
