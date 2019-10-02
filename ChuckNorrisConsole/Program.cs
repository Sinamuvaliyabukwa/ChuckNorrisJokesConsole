using ChuckNorrisJokesLibrary;
using System;
using System.Threading.Tasks;


namespace ChuckNorrisConsole
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            JokeGenerator jokeGenerator = new JokeGenerator();
            string randomJoke = await jokeGenerator.GetRandomJoke();
           Console.WriteLine(randomJoke);



            string[] categories = await jokeGenerator.GetCategories();
            for (int index = categories.Length - 1; index >= 0; index--)
            {
                Console.WriteLine(categories[index]);
            }
        }

        
    }
}
