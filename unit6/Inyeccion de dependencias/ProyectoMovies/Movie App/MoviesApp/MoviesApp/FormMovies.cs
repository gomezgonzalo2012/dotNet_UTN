using MoviesApp.Entities.Model;
using MoviesApp.Entities.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp
{
    public partial class FormMovies : Form
    {
        public  Movie FullMovie { get; set; }
        IIdiomaDatos IdiomaDatos { get; set; }
        //IMovieDatos MovieDatos { get; set; }
        public FormMovies( /*IMovieDatos movieData*/ IIdiomaDatos idiomaDatos)
        {
            InitializeComponent();
            //MovieDatos = movieData;
            this.IdiomaDatos = idiomaDatos;
            InitilizeComobox();

        }
        // Constructor utillizado cada vez que se quiere editar
        public FormMovies(IIdiomaDatos idiomaDatos, Movie movieEdit)
        {
            InitializeComponent();
            this.IdiomaDatos = idiomaDatos;

            txtID.Text = movieEdit.Id;
            txtTitle.Text = movieEdit.Title;
            txtBudget.Text= movieEdit.Budget.ToString();
            InitilizeComobox();

        }

        private void InitilizeComobox()
        {
            comboBoxLanguage.DataSource = IdiomaDatos.GetAllIdiomas();
            comboBoxLanguage.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validate = ValitateData(out string errorMessage);
            if (validate)
            {
                FullMovie = new Movie();
                FullMovie.Id = txtID.Text;
                FullMovie.Title = txtTitle.Text;
                FullMovie.Budget = float.Parse(txtBudget.Text);
                // idioma
                var idioma = IdiomaDatos.GetIdioma(comboBoxLanguage.SelectedIndex);
                FullMovie.OriginalLanguage =idioma;
                this.DialogResult = DialogResult.OK; // cierra esta ventana con ok
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // formato mensaje de error

                this.DialogResult= DialogResult.Cancel; // cierra esta ventana
            }
            

        }

        public bool ValitateData(out string errMessage)
        {
            errMessage = string.Empty;
            if (string.IsNullOrEmpty(txtID.Text)) {
                errMessage += "El campo ID no puede estar vacío. \n";
                }
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errMessage += "El campo Título no puede estar vacío. \n";
            }
            if (string.IsNullOrEmpty(txtBudget.Text))
            {
                errMessage += "El campo Presupuesto no puede estar vacío. \n";
            }
            // validacion float 
            bool floatOk = float.TryParse(txtBudget.Text, out float val);
            if (floatOk)
            {
                if (val < 0)
                {
                    errMessage += "El campo Presupuesto no puede  ser negativo. \n";
                }
                
            }
            else
            {
                errMessage += "El campo Presupuesto debe contener un numero valido. \n";
            }

            if (comboBoxLanguage.SelectedIndex == -1)
            {
                errMessage += "Debe seleccionar un idioma. \n";
            }
            var result = errMessage.Equals(string.Empty);
            return result;

        }
    }
}
