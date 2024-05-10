using Fomulario.Modelo;
using Fomulario.Repositorio;
using Fomulario.Repositorio.Interfaces;
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
    public partial class FormEditar : Form
    {
        private readonly IProductoDatos _productosDatos;
        private readonly IClienteDatos _clienteDatos;

        private ProductoModelo _productoAEditar;
        public FormEditar(IProductoDatos productoDatos, IClienteDatos clienteDatos)
        {
            InitializeComponent();
            _productosDatos = productoDatos;
            _clienteDatos = clienteDatos;
        }
        // obtenemos el producto desde el otro form
        public void SetProducto(ProductoModelo producto)
        {
            _productoAEditar = producto;
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            if (_productoAEditar != null)
            {
                //Rellenamos los textboxs con los datos del producto 
                txtId.Text = _productoAEditar.Id.ToString();
                txtId.Enabled = false; // evita edicion
                txtNombre.Text = _productoAEditar.Nombre;
                txtPrecio.Text = _productoAEditar.Precio.ToString();
                txtMarca.Text = _productoAEditar.Marca;
                txtIdCliente.Text = _productoAEditar.UnCliente.Id_cliente.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            ProductoModelo producto = new ProductoModelo()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = float.Parse(txtPrecio.Text),
                Marca = txtMarca.Text,
                UnCliente = _clienteDatos.BuscarCliente(int.Parse(txtIdCliente.Text))
            };
            editarProducto(producto);
            
            this.Close();
        }

        public void editarProducto(ProductoModelo producto)
        {
            _productosDatos.EditarUnProducto(_productoAEditar ,producto);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
