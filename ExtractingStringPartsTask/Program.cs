namespace ExtractingStringPartsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = "United States of America";
            string state = "California";
            string city = "San Fransicso";
            string landmark = "Alcatraz Island";

            // Output the length of state
            Console.WriteLine("Length of state: " + state.Length);

            // Concatenate the contents of city and landmark (add a space)
            Console.WriteLine("City + Landmark: " + city + " " + landmark);

            // Output the first character of country
            Console.WriteLine("First character of country: " + country[0]);

            // Output a concatenation of the first and last characters of city
            Console.WriteLine("First + Last char of city: " + city[0] + city[city.Length - 1].ToString());

            // Output the substring of landmark starting at 'c' to the end
            int indexC = landmark.IndexOf('c');
            if (indexC != -1)
                Console.WriteLine("Substring from 'c' in landmark: " + landmark.Substring(indexC));
            else
                Console.WriteLine("'c' not found in landmark");

            // Output the substring of country from first 'S' to first 'A'
            int indexS = country.IndexOf('S');
            int indexA = country.IndexOf('A', indexS); // start looking from indexS
            if (indexS != -1 && indexA != -1 && indexA > indexS)
                Console.WriteLine("Substring from 'S' to 'A': " + country.Substring(indexS, indexA - indexS + 1));
            else
                Console.WriteLine("Could not find suitable 'S' and 'A' in country");

            // Output the position of 'f' in "California"
            int indexF = state.IndexOf('f');
            Console.WriteLine("Position of 'f' in California: " + indexF);

            string[] labels = { "Country", "State", "City", "Landmark" };
            string[] values = { country, state, city, landmark };

            foreach (var (label, value) in labels.Zip(values))
            {
                int vowelCount = 0;
                foreach (char c in value.ToLower())
                {
                    if ("aeiou".Contains(c))
                        vowelCount++;
                }
                Console.WriteLine($"{label}: {value} has {vowelCount} vowels");
            }
        }
    }
}
