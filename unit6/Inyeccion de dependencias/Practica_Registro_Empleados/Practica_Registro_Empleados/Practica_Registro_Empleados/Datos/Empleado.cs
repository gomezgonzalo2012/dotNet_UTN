using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Registro_Empleados.Datos
{
    [Serializable]
    public class Empleado
    {
        public string Id { get;  set; }
        public string Nombre { get;  set; }
        public string Apellido1 { get;  set; }
        public string Apellido2 { get;  set; }
        public int Edad { get;  set; }
        public string Email { get;  set; }

        public Empleado() { }
        public Empleado(string id, string nombre, string apellido1, string apellido2, int edad, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Edad = edad;
            Email = email;
        }
    }
}
