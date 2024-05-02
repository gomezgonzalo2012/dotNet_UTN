using Fomulario.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fomulario.Datos
{
    public class UsuarioDatos
    {
        List<UsuarioModelo> listaUsuarios = new List<UsuarioModelo>();
        /// <summary>
        /// Guarda los usuarios 
        /// </summary>
        /// <param name="usuario"> datos del usuario</param>
        public void Guardar(UsuarioModelo usuario)
        {
            listaUsuarios.Add(usuario);
        }
        /// <summary>
        /// Consulta todos los usuarios
        /// </summary>
        /// <returns>Retorna todos los usuarios</returns>
        public List<UsuarioModelo> Consultar()
        {
            return listaUsuarios;
        }
    }
}
