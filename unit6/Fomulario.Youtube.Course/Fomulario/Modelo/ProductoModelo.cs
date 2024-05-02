using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fomulario.Modelo
{
    public class ProductoModelo
    {
        public int Id {  get; set; }
        public string Nombre { get; set; }
        public float Precio {  get; set; }
        public string Marca {  get; set; }
        public ClienteModelo UnCliente { get; set; }
    }
}
