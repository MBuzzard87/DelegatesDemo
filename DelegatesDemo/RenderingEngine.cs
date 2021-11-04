using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    class RenderingEngine
    {

        public void StartGame()
        {
            Console.WriteLine("Rendering engine started");
            Console.WriteLine("Drawing Visuals....");
        }

        public void GameOver()
        {
            Console.WriteLine("Rendering engine stopped");
        }

    }
}
