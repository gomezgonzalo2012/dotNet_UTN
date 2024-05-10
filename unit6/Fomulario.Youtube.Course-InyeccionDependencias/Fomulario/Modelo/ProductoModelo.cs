using Fomulario.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fomulario.Modelo
{
    public class ProductoModelo
    {
        private static int id_counter = Program.Id_counter;
        private  int id ;

        public string Nombre { get; set; }
        public float Precio {  get; set; }
        public string Marca {  get; set; }

        public ClienteModelo UnCliente { get; set; }
        public int Id
        {
           get
            {
                return id;
            }
            set
            {
                id = id_counter;
            }
        }


        public ProductoModelo() {
            
            Id = ++id_counter;
        }

        public ProductoModelo( string nombre, float precio, string marca, ClienteModelo unCliente) 
        {
            Id = ++id_counter;
            Nombre = nombre;
            Precio = precio;
            Marca = marca;
            UnCliente = unCliente; 
        }

    }
}
