using System;
using AnimalSounds;

namespace Tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalManager animalManager = new AnimalManager();
            animalManager.AddAnimal("Caine", "Ham");
            animalManager.AddAnimal("Pisica", "Miau");
            animalManager.AddAnimal("Vaca", "Muu");
            animalManager.AddAnimal("Pui", "Piu");
            animalManager.AddAnimal("Rata", "Mac");
            animalManager.AddAnimal("Leu", "Roar");

            Console.WriteLine("Sunete de animale\n");
            foreach (var animalType in animalManager.GetAnimalTypes())
            {
                Console.WriteLine($"{animalType} face sunetul: {animalManager.GetSound(animalType)}");
            }

            string soundOfElephant = animalManager.GetSound("Elefant");
            Console.WriteLine($"Elefantul face sunetul: { soundOfElephant}");

            Console.ReadKey();
        }
    }
}
