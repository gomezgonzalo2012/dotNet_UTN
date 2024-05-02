namespace Howarts.App.Entities
{
    public class Muggle
    {
        public int Id {  get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return base.ToString(); 
            // return $"Muggle: {Id} {Name}";
        }

        
    }
}
