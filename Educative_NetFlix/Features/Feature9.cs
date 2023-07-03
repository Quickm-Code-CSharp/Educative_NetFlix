using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educative_NetFlix.Features
{
    class Feature9
    {
        private List<String> combinations = new List<String>();
        // Mapping the categories to their corresponding movies
        private Dictionary<string, string[]> movies = new Dictionary<string, string[]>{
            { "Family", new string[3]{"Frozen","Kung fu Panda", "Ice Age"} },
            { "Action", new string[3]{"Iron Man","Wonder Woman","Avengers"}},
            { "Fantasy", new string[3]{"Jumangi", "Lion King", "Tarzan"}},
            { "Comedy", new string[4]{"Coco", "The Croods", "Vivi","Pets"}},
            { "Horror", new string[4]{"Oculus", "Sinister","Insidious","Annebelle"}},
        };

        public List<String> LetterCombinations(string[] categories)
        {
            combinations.Clear();

            // If the input is empty, immediately return an empty answer array
            if (categories.Length == 0)
            {
                return combinations;
            }

            // Initiate Backtracking with an empty path and starting index of 0

            Backtrack(0, new List<string>(), categories);
            return combinations;
        }

        private void Backtrack(int index, List<string> path, string[] categories)
        {
            // If the path is the same length as categories, we have a complete combination
            if (path.Count == categories.Length)
            {
                combinations.Add("'" + string.Join("", path) + "'");
                return; // Backtrack
            }

            // Get the movies that the current digit maps to, and loop through them
            string[] possibleMovies = movies[categories[index]];
            for (int i = 0; i < possibleMovies.Length; i++)
            {
                // Add the letter to our current path
                path.Add(possibleMovies[i] + ";");
                // Move on to the next digit
                Backtrack(index + 1, path, categories);
                // Backtrack by removing the letter before moving onto the next
                if (path.Count > 0)
                {
                    path.RemoveAt(path.Count - 1);
                }
            }
        }

        public void PrintOutput(string[] categories, List<string> combinations, string runTitle)
        {

            Console.WriteLine($"{Environment.NewLine}{runTitle}: ");

            // categories
            string categoriesStr = string.Join(" ", categories);

            Console.WriteLine($"Categories: {categoriesStr}");

            // combinations
            string output = string.Join(Environment.NewLine, combinations);
            Console.WriteLine("Output:");
            Console.WriteLine(output);
        }
    }
}
