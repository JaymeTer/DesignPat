using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A singleton that can be used as a gamemanager its basically our example from class. It could for example start a new instance of your game each time you push start.
// A singleton is a creational
// This is used in case you need a new instance each time, for example a game state where your game starts at the score of 0 everytime, or a server connection.
// https://refactoring.guru/design-patterns/singleton

namespace SingeltonDemo
{
    public class Singeltonthing
    {
        private static Singeltonthing instance { get; set; }

        public int Gamestate { get; set; }

        private Singeltonthing(int Gameint)
        {
           Gamestate = Gameint;
        }

        public Singeltonthing getInstance(int Gameint)
        {
            if (instance == null)
            {
                instance = new Singeltonthing(Gameint);
            }
            
            return instance;

        }
    }

    





}
