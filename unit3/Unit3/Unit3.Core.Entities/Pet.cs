namespace Unit3.Core.Entities
{
    public class Pet
    {
        public string? Name { get; set; } = "";
        public string? Breed { get; set; } // raza

        public DateOnly BirthDay { get; set; }

        public Pet() { }

        public Pet(string name, string breed, DateOnly birthDay)
        {
            Name = name;
            Breed = breed;
            BirthDay = birthDay;
        }

        public Pet(string name, string breed)
        {
            Name = name;
            Breed = breed;
           
        }


        public int Age()
        {
            return CalculateAge();
        }

        private int CalculateAge()
        {
            var today = DateOnly.FromDateTime(DateTime.Today);
            var age = today.Year - BirthDay.Year;
            if (BirthDay > today.AddYears(-age)) age--; // por año bisiesto
            return age;

        }
    }
}
