using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesApp.Entities.Model;

namespace MoviesApp.Entities.Repository
{
    public interface IMovieDatos
    {
        public void SaveMovie(Movie movie);
        public void DeleteMovie(string id);
        public IEnumerable<Movie> GetAllMovies();

        public void UpdateMovie(string idMovieOriginal,Movie movieModified);
    }
}
