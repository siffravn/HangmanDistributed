using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ServiceReference1;
using System.ServiceModel;

namespace GameGUI
{
    
    class gameController
    {
        private int clientID;
        private Hangman game;
        GameControllerClient client;

        public gameController()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress("http://localhost:8080/GameService/GameController");

            client = new GameControllerClient(binding, address);
        }

        public string Guess(string guessedWord)
        {

            Console.WriteLine(guessedWord);
            //TODO call guessword in backend
            game.VisibleWord = guessedWord;
            game.Lives++;

            return guessedWord;
        }
    }
}
