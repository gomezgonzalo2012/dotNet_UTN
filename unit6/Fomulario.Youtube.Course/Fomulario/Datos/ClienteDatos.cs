using Fomulario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fomulario.Datos
{
    public class ClienteDatos
    {
        List<ClienteModelo> listaClientes = new List<ClienteModelo> {
            new ClienteModelo("Bianca",1),
            new ClienteModelo("Monica",2),
            new ClienteModelo("Lautaro",3),
            new ClienteModelo("Gonzalo",4),

        };

        public ClienteModelo BuscarCliente(int id)
        {
            ClienteModelo client = null ;
            foreach (var c in listaClientes)
            {
                if (c.Id_cliente.Equals(id))
                {
                     return client = c; 
                }
                
            }
            //var client = (from cliente in listaClientes where cliente.Id_cliente == id select cliente) as ClienteModelo;
            return client;
        }

    }
}
