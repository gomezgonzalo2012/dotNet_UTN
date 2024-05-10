using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fomulario.Modelo;
using Fomulario.Repositorio.Interfaces;

namespace Fomulario.Repositorio
{
    public class ProductoDatos : IProductoDatos
    {
        /// <summary>
        /// Asimia una base de datos 
        /// </summary>
        ClienteDatos clienteDatos = new();
        //public static int Id_counter { get; set; } = 0;

        private List<ProductoModelo> listaProductos  = new List<ProductoModelo>()
        {
            new ProductoModelo("Termo",1200,"Stanley", ClienteDatos.listaClientes[0]),
            new ProductoModelo("Bombilla",200,"Stanley", ClienteDatos.listaClientes[2]),
            new ProductoModelo("Mate",600,"Stanley", ClienteDatos.listaClientes[3])

        };

    public ProductoDatos()
        {
        }

        /// <summary>
        /// Guarda el producto 
        /// </summary>
        /// <param name="producto"></param>
        public void GuardarProducto(ProductoModelo producto)
        {
            listaProductos.Add(producto);
        }
        /// <summary>
        /// Consulta la lista o Base de datos
        /// </summary>
        /// <returns></returns>
        public List<ProductoModelo> ConsultarProductos()
        {
            return listaProductos;

        }
        public ClienteModelo BuscarCliente(int id_cliente)
        {
            return clienteDatos.BuscarCliente(id_cliente);
        }

        public ProductoModelo BuscarProducto(int id_producto)
        {
            ProductoModelo? producEncontrado = null;
            foreach(var item in listaProductos)
            {
                if(item.Id == id_producto)
                {
                    producEncontrado = item;
                }
                
            }
           return producEncontrado;
        }

        public void EditarUnProducto(ProductoModelo productoAEditar, ProductoModelo producto)
        {
            //busca por id
            var prodEncontrado = BuscarProducto(productoAEditar.Id);
            if (prodEncontrado != null)
            {
                // obtiene el indice
                var indx = listaProductos.IndexOf(productoAEditar);
                // sobre escribe
                listaProductos[indx] = producto;
            }
            else
            {
                listaProductos.Add(producto);
            }      
        }

    }
}
