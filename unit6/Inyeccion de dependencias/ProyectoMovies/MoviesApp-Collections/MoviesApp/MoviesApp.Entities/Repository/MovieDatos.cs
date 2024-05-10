using MoviesApp.Entities.Model;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp.Entities.Repository
{
    public class MovieDatos : IMovieDatos
    {
        //public static List<Movie> ListMovies {  get; set; }
        public static BlockingCollection<Movie> ListMovies {  get; set; } = new BlockingCollection<Movie>(new ConcurrentQueue<Movie>())
            {
                new Movie("1","Mad Max", IdiomaDatos.Idiomas[1],120000),
                new Movie("4","Woder Woman", IdiomaDatos.Idiomas[3],190000),
                new Movie("12","Man of Steel", IdiomaDatos.Idiomas[2],320000),
                new Movie("2","Avengers: Endgame", IdiomaDatos.Idiomas[0],400000),
            };

        public  MovieDatos()
        {
            //ListMovies = new List<Movie>();
           

        }
        // CRUD methods
        public void SaveMovie(Movie movie)
        {
            ListMovies.Add(movie);
        }
        public void DeleteMovie(string id)
        {
            var listMovie2 = ListMovies.ToList();

            // opcion 1
            //listMovie2.RemoveAll(movie => movie.Id.Equals(id));
            // opcion 2
            var index = listMovie2.FindIndex(movie => movie.Id == id);
            if (index != -1)
            {
                listMovie2.RemoveAt(index);
            }
            // asigna la lista editada a la BloquingCollection
            var blocingDefinitiva = new BlockingCollection<Movie>(new ConcurrentQueue<Movie>(listMovie2));

            ListMovies = blocingDefinitiva;

            //No funcionan: 
            //var removed = ListMovies.ToList().RemoveAll(movie => movie.Id.Equals(id));

            //ListMovies.TakeWhile(movie => movie.Id.Equals(id));

        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return ListMovies;
        }

       

        public void UpdateMovie(string idMovieOriginal, Movie movieModified)
        {   
            // transforma la blocquincollection en una lista para poder usar el metodo FindIndex()
            var listMovie2 = ListMovies.ToList();

            // ecuentra el indice de la pelicula a editar
            var indFound = listMovie2.FindIndex(movie => movie.Id.Equals(idMovieOriginal));
            
            if (indFound != -1)
            {
                listMovie2[indFound]= movieModified;
              
            }
            // asigna la lista editada a la BloquingCollection
            var blocingDefinitiva = new BlockingCollection<Movie> (new ConcurrentQueue<Movie>(listMovie2));
            
            ListMovies = blocingDefinitiva;

            // No funcionan:
            //ListMovies = (BlockingCollection<Movie>)((IProducerConsumerCollection<Movie>)listMovie2) ;
            //var blc = new BlockingCollection<Movie>((IProducerConsumerCollection<Movie>)listMovie2);

        }

        
        
    }
}
