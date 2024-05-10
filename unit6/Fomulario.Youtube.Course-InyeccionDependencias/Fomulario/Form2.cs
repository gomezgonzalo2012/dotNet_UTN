using Fomulario.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fomulario.Repositorio.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Fomulario
{
    public partial class Form2 : Form
    {
        DataTable tabla;
        private IClienteDatos _clienteDatos;
        private IProductoDatos _productoDatos;
        ProductoModelo productoSeleccionado; // se utiliza para pasar al form editar

        public Form2(IClienteDatos clienteDatos, IProductoDatos productoDatos)
        {
            InitializeComponent();
            _clienteDatos = clienteDatos;
            _productoDatos = productoDatos;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            IniciarTabla();
            ConsultarProductos();
            txtId.Enabled = false; // evita edicion

        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            IniciarTabla();
            CargarProducto();
            ConsultarProductos();
            Limpiar();

        }

        public void IniciarTabla()
        {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Marca");
            tabla.Columns.Add("Cliente");
            GridProductos.DataSource = tabla;

        }

        public void CargarProducto()
        {
            ProductoModelo producto = new ProductoModelo()
            {
                //Id = int.Parse(txtId.Text), 
                Nombre = txtNombre.Text,
                Precio = float.Parse(txtPrecio.Text),
                Marca = txtMarca.Text,
                UnCliente = _clienteDatos.BuscarCliente(int.Parse(txtIdCliente.Text))
            };
            _productoDatos.GuardarProducto(producto);

        }

        public void ConsultarProductos()
        {
            //    tabla.Rows.Clear(); // evita que se repitan datos anteriores

            var lista = _productoDatos.ConsultarProductos();

            // seteando automaticamente los datos del datagridview
            GridProductos.AutoGenerateColumns = false;

            GridProductos.DataSource = lista;


            // generacion de manera manual
            foreach (var item in lista)
            {
                DataRow fila = tabla.NewRow();
                fila[0] = item.Id;
                fila[1] = item.Nombre;
                fila[2] = item.Precio;
                fila[3] = item.Marca;
                fila[4] = item.UnCliente.Nombre;
                tabla.Rows.Add(fila);   // agrega la fila a la tabla
            }
        }

        public void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtMarca.Text = "";
            txtIdCliente.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (GridProductos.SelectedRows.Count > 0)
            {
                // obtenemos el producto seleccionado
                var row = GridProductos.SelectedRows[0];
                productoSeleccionado = (ProductoModelo)row.DataBoundItem;
                // pasamos el producto al form Editar
                var formEditar = Program.ServiceProvider.GetRequiredService<FormEditar>();
                formEditar.SetProducto(productoSeleccionado);
                formEditar.Show();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para editar");
            }
        }
    }
}
