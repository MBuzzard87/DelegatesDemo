using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{

    
    class Player
    {

        public string PlayerName { get; set; }

        public Player(string name)
        {
            PlayerName = name;
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawning player with ID: {PlayerName}");
        }

        private void GameOver()
        {
            Console.WriteLine($"Removing player with ID: {PlayerName}");
        }


    }
}
