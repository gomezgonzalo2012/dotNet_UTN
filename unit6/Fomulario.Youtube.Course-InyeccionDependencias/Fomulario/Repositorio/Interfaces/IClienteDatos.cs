using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fomulario.Modelo;

namespace Fomulario.Repositorio.Interfaces
{
    public interface IClienteDatos
    {
        public ClienteModelo BuscarCliente(int id_cliente);

    }

}
