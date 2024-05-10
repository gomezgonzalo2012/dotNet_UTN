using Practica_Registro_Empleados.Datos;
using Practica_Registro_Empleados.Formularios;

namespace Practica_Registro_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EmpleadoRepositorio.InicializarRepositorio(); // lo inicialzamos ya que lo ocupamos debajo
            VisualizarEmpleados();

        }

        public void VisualizarEmpleados()
        {
            dataGridView1.Rows.Clear();
            foreach (Empleado emple in EmpleadoRepositorio.Empleados)
            {
                var rowIndex = dataGridView1.Rows.Add(); //agrega una nueva fila y retorna su inidice
                dataGridView1.Rows[rowIndex].Cells[0].Value = emple.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = emple.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = emple.Apellido1.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = emple.Apellido2.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = emple.Edad.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = emple.Email.ToString();
            }
        }


        private void picBoxAgregar_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleadoForm = new EmpleadoForm();
            DialogResult dialogResult = empleadoForm.ShowDialog();// muestra el form y bloque hasta que el se cierre
            // resultado del EmpleadoForm
            if (dialogResult == DialogResult.OK)
            {
                EmpleadoRepositorio.GuardarEmpleado(empleadoForm.Empleado); //guardar el empleado del EmpleadoForm
                VisualizarEmpleados();
            }
        }

        private void picBoxModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                // recuperamos los datos 
                string idEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombreEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string apellido1EmpleadoModificar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string apellido2EmpleadoModificar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                int edadEmpleadoModificar = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[4].Value);
                string emailEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Empleado empleadoModificar = new Empleado(idEmpleadoModificar, nombreEmpleadoModificar, apellido1EmpleadoModificar, apellido2EmpleadoModificar, edadEmpleadoModificar, emailEmpleadoModificar);
               
                EmpleadoForm empleadoFormEditar = new EmpleadoForm(empleadoModificar); // form editar
                DialogResult dialogResult = empleadoFormEditar.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    EmpleadoRepositorio.ActualizarEmpleado(idEmpleadoModificar, empleadoFormEditar.Empleado);
                    VisualizarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("No haz seleccionado ningun empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBoxEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0){
                // de las fila seleccionardas dame la primera => y dame el valor de la celda primera (id)
                string idEmpleadoEliminar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EmpleadoRepositorio.EliminarEmpleado(idEmpleadoEliminar);
                VisualizarEmpleados();
            }
            else
            {
                MessageBox.Show("No haz seleccionado ningun empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
