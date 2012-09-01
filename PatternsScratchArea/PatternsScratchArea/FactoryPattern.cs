using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsScratchArea
{
    public interface IAnimal
    {

        string Eat();

        string Sleep();

    }
    public class Dog : IAnimal
    {

        public string Eat()
        {
            //do some work here
            return "Yum";
        }

        public string Sleep()
        {
            // do some work here
            return "snore";
        }
    }

    public class Cat : IAnimal
    {

        public string Eat()
        {
            // do some work
            return "Yum";
        }

        public string Sleep()
        {
            //do some work
            return "snore";
        }
    }

    public class AnimalFactory
    {
        public IAnimal GetAnimalBySound(string animalNoise)
        {
            IAnimal animal = null;
            switch (animalNoise)
            {
                case "Woof":
                    animal = new Dog();
                    break;

                case "Meow":
                    animal = new Cat();
                    break;
            }
            return animal;
        }
    }



}
