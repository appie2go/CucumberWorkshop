using System.Collections.Generic;
using System.Linq;

namespace VXCompany.Cucumber
{

    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Tussenvoegsel { get; set; }
        public string Achternaam { get; set; }
        private List<Hobby> Hobbies { get; set; }

        public string VolledigeNaam
        {
            get 
            {
                var namen = new[] { Voornaam, Tussenvoegsel, Achternaam };
                return string.Join(" ", namen.Where(x => !string.IsNullOrEmpty(x)));
            }
        }


        public override string ToString()
        {
            return $"{VolledigeNaam} heeft hobbies: {Hobbies}";
        }
    }
}
