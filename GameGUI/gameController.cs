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
       
        public string HiddenWord { get; set; }

        
        public string VisibleWord { get; set; }

       
        public int Lives { get; set; }

      
        public ArrayList UsedLetters { get; set; } = new ArrayList();

        public bool IsGameWon { get; set; }

       
        public bool IsGameLost { get; set; }

     
        public bool IsGuessCorrect { get; set; }


        public string Guess(string guessedWord)
        {

            Console.WriteLine(guessedWord);
            //TODO call guessword in backend
            VisibleWord = guessedWord;
            Lives++;
            
            return guessedWord;
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


    }
}
