using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Class_examples
{
    internal class Pikachu : Pokemon
    {
        //extra variable
        public int Voltage;

        public Pikachu (string name, int Level, int voltage)
            :base (name, Level)
        {
            Voltage = voltage;
        }
        //unique simple method
        public void ThunderShock()
        {
            Console.WriteLine($"{Name} uses Thundershock: {Voltage} volts!");
        }
    }
}
