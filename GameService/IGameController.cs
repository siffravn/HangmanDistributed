using GameService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GameService
{
    [ServiceContract]
    public interface IGameController
    {
        [OperationContract]
        int CreateGame();

        [OperationContract]
        void TerminateGame(int id);

        [OperationContract]
        Hangman Guess(int id, string guess);

        [OperationContract]
        Hangman NewGame(int id);

        [OperationContract]
        int ComputeScore(int id);
    }

}
