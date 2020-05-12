using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ServiceReference1;
using System.ServiceModel;

namespace GameGUI
{
    
    public class GameController
    {
        private int clientID;
        public Hangman game = new Hangman();
        GameControllerClient client;
        public int score;

        public GameController()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://localhost:8080/GameService/GameController");


            client = new GameControllerClient(binding, address);
            clientID = client.CreateGameAsync().Result;
        }

        public async System.Threading.Tasks.Task<string> GuessAsync(string guessedWord)
        {
            //TODO call guessword in backend

            game = await client.GuessAsync(clientID, guessedWord);

            if (game.IsGameLost || game.IsGameWon)
            {
                await CalcScore();
                await client.TerminateGameAsync(clientID);
            }
           

            return guessedWord;
        }

        public async System.Threading.Tasks.Task<int> CalcScore()
        {
            
            score = await client.ComputeScoreAsync(clientID);
            return score;
        }
    }
}
