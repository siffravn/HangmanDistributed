using GameService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameService
{
    public class GameController : IGameController
    {

        private static Dictionary<int, Hangman> games = new Dictionary<int, Hangman>();
        private static Words words = new Words();

        public int ComputeScore(int id)
        {
            int totalscore = 0; 
            Hangman hangman = games[id];
            int lives = hangman.Lives;
            int usedLetters = hangman.UsedLetters.Count;

            totalscore += (lives * 7);
            totalscore -= (usedLetters * 2);

            return totalscore;

        }

        public int CreateGame()
        {
            Hangman hangman = new Hangman();
            Random random = new Random();
            bool added = false;
            int id = 0;

            while (!added)
            {
                try
                {
                    id = random.Next(0, 101);
                    games.Add(id, hangman);
                    added = true;
                }
                catch (ArgumentException e)
                {
                }
            }

            return id;
        }

        public Hangman Guess(int id, string guess)
        {
            Hangman hangman = games[id];
            hangman.Guess(guess);

            return hangman;
        }

        public Hangman NewGame(int id)
        {
            Hangman hangman = games[id];

            hangman.Reset();
            hangman.setHiddenWord(words.Random());

            return hangman;
        }

        public void TerminateGame(int id)
        {
            games.Remove(id);
        }
    }
}
