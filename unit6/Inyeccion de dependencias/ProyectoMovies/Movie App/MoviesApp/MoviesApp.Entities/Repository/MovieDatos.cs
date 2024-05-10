using MoviesApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp.Entities.Repository
{
    public class MovieDatos : IMovieDatos
    {
        public static List<Movie> ListMovies {  get; set; }

        public  MovieDatos()
        {
            ListMovies = new List<Movie>();
        }
        // CRUD methods
        public void SaveMovie(Movie movie)
        {
            ListMovies.Add(movie);
        }
        public void DeleteMovie(string id)
        {
            ListMovies.RemoveAll(movie => movie.Id.Equals(id));
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return ListMovies;
        }

       

        public void UpdateMovie(string idMovieOriginal, Movie movieModified)
        {
            // ecuentra el indice de la pelicula a editar
            var idFound = ListMovies.FindIndex(movie => movie.Id.Equals(idMovieOriginal));
            if (idFound != -1)
            {
                ListMovies[idFound] = movieModified;
            }
        }
    }
}
