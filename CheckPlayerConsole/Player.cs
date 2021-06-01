using System;
using System.Collections.Generic;
using System.Text;

namespace CheckPlayerConsole
{
    abstract class Player
    {
        public int Id;
        public string Name;
        public int WeightStandart { get; }
        public double Height {get;}
        public int PulseStandart { get;  }
        public string PressureStandart { get; }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;

        }

        protected Player()
        {

        }
    }
}
