using Practica_Registro_Empleados.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Registro_Empleados.Formularios
{
    public partial class EmpleadoForm : Form
    {
        public Empleado Empleado { get; private set; } // obtener el empleado desde el otro form
        public EmpleadoForm()
        {
            InitializeComponent();
        }
        public EmpleadoForm(Empleado empleado) // siempre que entremos al form para editar
        {
            InitializeComponent();
            txtIdEmpleado.Text= empleado.Id;
            txtNombre.Text= empleado.Nombre;
            txtApellido1.Text= empleado.Apellido1;
            txtApellido2.Text= empleado.Apellido2;
            txtEdad.Text= empleado.Edad.ToString();
            txtMail.Text= empleado.Email;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool empleadoValidado = ValidarEmpleado(out string errorMessage);
            if (empleadoValidado)
            {
                Empleado = new Empleado(txtIdEmpleado.Text, txtNombre.Text, txtApellido1.Text,
                    txtApellido2.Text, Convert.ToInt32(txtEdad.Text), txtMail.Text);
                this.DialogResult = DialogResult.OK; // cierra el actual form y siver para verificar la validacion desde el otro form
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // formato mensaje de error
                this.DialogResult = DialogResult.Cancel; // cierra el form}

            }
        }

        private bool ValidarEmpleado( out string errorMessage) //valida cada dato 
        {
            errorMessage = string.Empty;
            if (string.IsNullOrEmpty(txtIdEmpleado.Text))
            {
                errorMessage += "El ID del empleado no puede estar vacío. \n";
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorMessage += "El nombre del empleado no puede estar vacío. \n";
            }
            if (string.IsNullOrEmpty(txtApellido1.Text))
            {
                errorMessage += "El primer apellido del empleado no puede estar vacío. \n";
            }
            if (string.IsNullOrEmpty(txtApellido2.Text))
            {
                errorMessage += "El segundo apellido del empleado no puede estar vacío. \n";
            }

            // validacion de la edad
            bool edadOk = double.TryParse(txtEdad.Text, out double edad);

            if (edadOk)
            {
                if (edad < 16)
                {
                    errorMessage += "La edad del empleado debe ser superior a 16 años.\n";
                }
            }
            else
            {
                errorMessage += "La edad del empleado debe ser un número válido.\n";
            }

            // validacion de email
            try
            {
                new MailAddress(txtMail.Text);
            }
            catch (Exception ex)
            {
                errorMessage += "El email debe tener un formato correcto.\n";
            }
            bool areEquals =  errorMessage.Equals(string.Empty);
            return areEquals; // si esta vacío todo salió bien
        }
    }
}
