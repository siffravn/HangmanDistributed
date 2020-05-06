using System;
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


    }
}
