using MoviesApp.Entities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp.Entities.Repository
{
    public interface IIdiomaDatos
    {
        public Idioma GetIdioma(int id);

        public List<Idioma> GetAllIdiomas()


;    }
}
