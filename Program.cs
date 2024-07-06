using System;
using Tema1.Base;

namespace Tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (IAnimal animal in AnimalFactory.GetAnimals())
            {
                animal.MakeSound();
            }
            Console.ReadKey();
        }
    }
}