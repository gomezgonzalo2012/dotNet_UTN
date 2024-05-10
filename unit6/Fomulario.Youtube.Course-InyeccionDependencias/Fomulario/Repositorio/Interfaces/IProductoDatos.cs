using Fomulario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fomulario.Repositorio.Interfaces
{
    public interface IProductoDatos
    {
        public void GuardarProducto(ProductoModelo producto);
        public List<ProductoModelo> ConsultarProductos();

        public ProductoModelo BuscarProducto(int id_producto);

        public ClienteModelo BuscarCliente(int id_cliente);

        public void EditarUnProducto(ProductoModelo productoAEditar,ProductoModelo producto);

    }
}
