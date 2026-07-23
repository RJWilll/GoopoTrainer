using System;
using System.Collections.Generic;
using System.Text;

namespace GoopoTrainer.Backend
{
    public class Muscle
    {
        public string name;
        public int size;
        public int strength;

        public Muscle()
        {
            name = "Muscle";
            size = 0;
            strength = 0;
        }

        public Muscle(string name)
        {
            this.name = name;
            size = 0;
            strength = 0;
        }

        public Muscle(string name,  int size, int strength)
        {
            this.name = name;
            this.size = size;
            this.strength = strength;
        }

        public Muscle(int size, int strength)
        {
            this.size = size;
            this.strength = strength;
        }

        public void ReplaceStats(Muscle muscle)
        {
            this.size = muscle.size;
            this.strength = muscle.strength;
        }
    }
}
