using System.Collections.Generic;
using Tema1.Base;
using Tema1.Models;

namespace Tema1
{
    public class AnimalFactory
    {
        public static IEnumerable<IAnimal> GetAnimals()
        {
            var animals = new List<IAnimal>
            {
                new Cat(),
                new Cow(),
                new Dog(),
                new Duck(),
                new Frog(),
                new Lion(),
        };
            return animals;
        }
    }

}