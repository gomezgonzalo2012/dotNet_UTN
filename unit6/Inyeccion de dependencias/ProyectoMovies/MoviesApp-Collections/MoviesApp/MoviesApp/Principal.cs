using MoviesApp.Entities.Repository;
using MoviesApp.Entities.Model;

namespace MoviesApp
{
    public partial class Principal : Form
    {
        IMovieDatos MovieRepository { get; set; }
        IIdiomaDatos IdiomaRepository { get; set; }
        public Principal(IMovieDatos movieDatos, IIdiomaDatos idiomaDatos)
        {
            InitializeComponent();
            this.MovieRepository = movieDatos;
            IdiomaRepository = idiomaDatos;

            SetTableData();
        }

        public void SetTableData()
        {
            dataGridView1.Rows.Clear();// limpia y evita datos repetidos
            foreach (var item in MovieRepository.GetAllMovies())
            {
                var rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = item.Id;
                dataGridView1.Rows[rowIndex].Cells[1].Value = item.Title;
                dataGridView1.Rows[rowIndex].Cells[2].Value = item.OriginalLanguage.Name;
                dataGridView1.Rows[rowIndex].Cells[3].Value = item.Budget.ToString();

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormMovies formMovies = new FormMovies(IdiomaRepository);
            var dialogResult = formMovies.ShowDialog(); // guardar dialog

            if (dialogResult == DialogResult.OK)
            {
                MovieRepository.SaveMovie(formMovies.FullMovie);
                SetTableData();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Movie movieEdit = new Movie(); // creada para pasar los datos al formulario de edicion
                movieEdit.Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                movieEdit.Title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                movieEdit.OriginalLanguage = new Idioma(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                movieEdit.Budget = float.Parse(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

                FormMovies formEditMovies = new FormMovies(IdiomaRepository, movieEdit); // form en modo edicíon
                DialogResult dialogResult = formEditMovies.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    MovieRepository.UpdateMovie(movieEdit.Id, formEditMovies.FullMovie); // actualizamos la movie
                    SetTableData();
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0) {
                string idMovieDelete = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                MovieRepository.DeleteMovie(idMovieDelete);
                SetTableData();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ninguna película", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }

}
