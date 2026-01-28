using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Class_examples
{
    class Pokemon
    {
        protected string Name;
        protected int Level;

        //const 1
        //runs when we only know the name
        public Pokemon(string name)
        {
            Name = name;
            Level = 1;
        }

        //constructor 2 (chaining)
        //this calls for the first constructor by using :this(name)
        public Pokemon(string name, int level) : this(name)
        { 
            Level = level;
        }
        public void speak()
        {
            Console.WriteLine($"{Name}!");
        }

        
    }
}
