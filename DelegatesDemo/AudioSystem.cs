using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class AudioSystem
    {

        public void StartGame()
        {
            Console.WriteLine("Audio system started...");
            Console.WriteLine("Playing audio...");
        }

        public void GameOver()
        {
            Console.WriteLine("Audio system stopped");
        }


    }
}
