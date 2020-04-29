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

        public int ComputeScore(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateGame(int id)
        {
            throw new NotImplementedException();
        }

        public Hangman Guess(int id, string guess)
        {
            throw new NotImplementedException();
        }

        public Hangman NewGame(int id)
        {
            throw new NotImplementedException();
        }

        public void TerminateGame(int id)
        {
            throw new NotImplementedException();
        }
    }
}
