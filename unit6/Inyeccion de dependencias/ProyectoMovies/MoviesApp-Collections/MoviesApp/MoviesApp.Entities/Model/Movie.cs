namespace MoviesApp.Entities.Model
{
    [Serializable]
    public class Movie
    {
        public string? Id {  get; set; }
        public string? Title { get; set; }
        public Idioma? OriginalLanguage { get; set; }    
        public float? Budget  {  get; set; } // presupuesto
        
        public Movie() { }
        public Movie(string id, string title,Idioma idioma,float budget ) {
            Id= id;
            Title= title;
            OriginalLanguage= idioma;
            Budget = budget;
        }
    }
}
