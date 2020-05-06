using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameServiceClient.ServiceReference1;

namespace GameServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Create an instance of the WCF proxy.
            GameControllerClient client = new GameControllerClient();

            // Step 2: Call the service operations.
            Hangman game = client.CreateGame(123);
            Console.WriteLine(game.HiddenWord);

            // Step 3: Close the client to gracefully close the connection and clean up resources.
            Console.WriteLine("\nPress <Enter> to terminate the client.");
            Console.ReadLine();
            client.Close();
        }
    }
}
