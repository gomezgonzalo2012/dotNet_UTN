namespace TestPersona.Entities
{
    public class Person
    {
        public string Name {  get; set; } // Property: No need to define a separetly Getter and Setter
        private string _lastName;  // atributte
        public string LastName { // Getter and Setter
            get
            {
                return _lastName;
            }

            set 
            {
                _lastName = value;
            }
            }
        public string FullName
        {
            get {
                return $"{Name} {_lastName}";
            }
        }

        public string FullName2()
        {
            return Name+" "+LastName;
        }
        
        public bool ReturnNameEndsWithDoubleZero()
        {
            if(string.IsNullOrEmpty(Name)) return false;
            if (Name.Length == 1) return false;

            var nameEnd = Name.Substring(Name.Length - 2);
            return nameEnd == "00";
            
        }
    }
}
