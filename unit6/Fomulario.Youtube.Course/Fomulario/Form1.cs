using Fomulario.Datos;
using Fomulario.Modelo;
using System.Data;

namespace Fomulario
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
            //Iniciar();
            Limpiar();
            Consultar();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre"); // agrega columna
            tabla.Columns.Add("Edad"); // agrega columna
            grillaDatos.DataSource = tabla;
        }
        /// <summary>
        /// Crea un nuevo Usuario, lo settea y lo guarda 
        /// </summary>
        private void Guardar()
        {
            UsuarioModelo usuarioModelo = new UsuarioModelo()
            {
                Nombre = txtNombre.Text,
                Edad = int.Parse(txtEdad.Text),
            };

            usuarioDatos.Guardar(usuarioModelo);
        }

        private void Consultar()
        {
            tabla.Rows.Clear(); // evita que se repitan datos anteriores
            foreach(var item in usuarioDatos.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila[0] = item.Nombre; // fila["Nombre"]
                fila[1] = item.Edad;//  fila["Edad"]
                tabla.Rows.Add(fila);   // agrega la fila a la tabla
            }
            
        }
        private void Limpiar()
        {
            txtEdad.Text = "";
            txtNombre.Text = "";
        }
    }
}
