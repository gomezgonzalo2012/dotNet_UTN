using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Registro_Empleados.Datos
{
    public class EmpleadoRepositorio
    {
        // ruta donde se guardara el archivo JSON

        private const string RUTA_FICHERO_EMPLEADOS = @"C:\Users\gomez\OneDrive\Desktop\Lab\Inyeccion de dependencias\Empleados.json";
        public static List<Empleado> Empleados {  get; private set; }

        public static void InicializarRepositorio()
        {
            // por el sí: 
            if(File.Exists(RUTA_FICHERO_EMPLEADOS)) // verifica que el archivo existe
            {
                string json = File.ReadAllText(RUTA_FICHERO_EMPLEADOS);// lee el archivo 
                Empleados = JsonConvert.DeserializeObject<List<Empleado>>(json); // al json lo desearializa en una List<Empleado>

            }
            else {
                Empleados = new List<Empleado>();
            }
            
        }

        public static void GuardarEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
            // serializa la lista en onjeto json generando la correcta identacion
            string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
            // guardamos el string serializado al fichero
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS,json);
        }

        public static void EliminarEmpleado(string id)
        {
            // elimina las coincidencias de ese id
            Empleados.RemoveAll(emp => emp.Id.Equals(id));
            string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
        }

        public static void ActualizarEmpleado(string idEmpleadoOrigen, Empleado empleadoModificado)
        {
            // busca el indice del empleado original
            int indiceEmpleadoOriginal = Empleados.FindIndex(emp=> emp.Id == idEmpleadoOrigen);
            if(indiceEmpleadoOriginal != -1)
            {
                Empleados[indiceEmpleadoOriginal] = empleadoModificado;
            }
            string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
        }
    }
}
