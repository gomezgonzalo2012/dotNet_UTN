using Fomulario.Datos;
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

namespace Fomulario
{
    public partial class Form2 : Form
    {
        DataTable tabla;
        private ClienteDatos _clienteDatos;
        private ProductoDatos _productoDatos;

        public Form2()
        {
            InitializeComponent();
            _clienteDatos = new ClienteDatos();
            _productoDatos = new ProductoDatos();

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
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = float.Parse(txtPrecio.Text),
                Marca = txtMarca.Text,
                UnCliente = _clienteDatos.BuscarCliente(int.Parse(txtIdCliente.Text))
            };
            _productoDatos.GuardarVenta(producto);

        }

        public void ConsultarProductos()
        {
            tabla.Rows.Clear(); // evita que se repitan datos anteriores
            foreach (var item in _productoDatos.ConsultaVentas())
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

        private void btnLimpiar_Click(object sender, EventArgs e)
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
    }
}
