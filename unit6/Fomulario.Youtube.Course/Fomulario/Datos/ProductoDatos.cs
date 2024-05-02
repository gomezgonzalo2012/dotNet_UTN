using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fomulario.Modelo;

namespace Fomulario.Datos
{
    public class ProductoDatos
    {
        /// <summary>
        /// Asimia una base de datos 
        /// </summary>
        List<ProductoModelo> listaProductos = new List<ProductoModelo>();


        ClienteDatos clienteDatos = new ();

        /// <summary>
        /// Guarda el producto 
        /// </summary>
        /// <param name="producto"></param>
        public void GuardarVenta(ProductoModelo producto)
        {
            listaProductos.Add(producto);
        }
        /// <summary>
        /// Consulta la lista o Base de datos
        /// </summary>
        /// <returns></returns>
        public List<ProductoModelo> ConsultaVentas()
        {
            return listaProductos;

        }
        public ClienteModelo buscarCliente(int id_cliente)
        {
            return clienteDatos.BuscarCliente(id_cliente);
        }
    }
}
