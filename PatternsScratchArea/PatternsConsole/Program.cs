using PatternsScratchArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory factory = new AnimalFactory();
            IAnimal mypet = factory.GetAnimalBySound("Woof");
            //Do some dog work
            mypet = factory.GetAnimalBySound("Meow");
            //Now my pet is a cat

        }

    }
}
