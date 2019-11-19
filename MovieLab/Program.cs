using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace MovieLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput, startOver;
            List<Movie> movieList = new List<Movie>()
            {
                { new Movie("Toy Story", "animated") },
                { new Movie("Shawshank Redemption", "drama") },
           { new Movie("Scream", "horror") },
           { new Movie("Forrest Gump", "drama") },
           { new Movie("Little Mermaid", "animated") },
          { new Movie("Pretty Woman", "drama") },
           { new Movie("CandyMan", "horror") } ,
           { new Movie("Star Wars", "sci-fi")},
          { new Movie("Harry Potter and the Sorcerer's Stone", "sci-fi")},
          { new Movie("Texas Chainsaw Massacre", "horror")},
                {new Movie ("Return of the Jedi","sci-fi") },
                {new Movie("Empire Strikes Back", "sci-fi") },
                {new Movie("The Secret Life of Pets","animated") },
                {new Movie("Poltergeist","horror") }
        };
                         //validate user entry of category choice.          
              Regex choice = new Regex(@"^(horror)|(Horror)|HORROR|drama|Drama|DRAMA|ANIMATED|Animated|animated|(sci\-fi)|(SCI\-FI)");
                      
            do
            {
                do
                {
                    Console.WriteLine("Hello, and welcome to our little movie database. Please select a movie category from the following:\n");
                    Console.WriteLine("Animated");
                    Console.WriteLine("Drama");
                    Console.WriteLine("Horror");
                    Console.WriteLine("Sci-fi");
                    //regex method from above loops if incorrect entry.
                    userInput = Console.ReadLine();
                    if (choice.Match(userInput).Success == false)
                    {
                        Console.WriteLine("\nSorry, that's not valid, please try again");
                    }
                }
                while (choice.Match(userInput).Success == false);

                Console.WriteLine("\nHere are some great choices for you:\n");
                foreach (Movie movie in movieList)
                {
                    if (movie.Category == userInput)
                    {
                        Console.WriteLine(movie.Title);
                    }
                }
                do
                {
                    Console.WriteLine("\nShall we start over? 'y' or 'n'");
                    startOver = Console.ReadLine().ToLower();
                    if (startOver != "n" && startOver != "y")
                    {
                        Console.WriteLine("\nOops, try again, 'y' or 'n'");
                    }
                    if (startOver == "n")
                    {
                        Console.WriteLine("\nOk, Ciao, adios, buh bye!");
                    }
                }

                while (startOver != "n" && startOver != "y");


            }
            while (startOver == "y");
        }

    }
}
