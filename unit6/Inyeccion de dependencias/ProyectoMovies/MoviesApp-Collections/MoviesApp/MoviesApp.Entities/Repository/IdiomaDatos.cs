using MoviesApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp.Entities.Repository
{
    public class IdiomaDatos : IIdiomaDatos
    {
        //public List<Idioma> Idiomas { get; set; }
        public static List<Idioma> Idiomas { get; set; }
        public IdiomaDatos() {
            Idiomas = new List<Idioma>()
            {
                new Idioma("Spanish"),
                new Idioma("English"),
                new Idioma("Japanese"),
                new Idioma("Mandarin"),
                new Idioma("Portuguese")
            };
        }

        public Idioma GetIdioma(int id)
        {
            return Idiomas.ElementAt(id);
        }
        public List<Idioma> GetAllIdiomas()
        {
            return Idiomas;
        }
    }
}
