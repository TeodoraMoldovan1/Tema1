using System;
using AnimalSounds;

namespace Tema1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalManager animalManager = new AnimalManager();
            PopulateAnimalSounds(animalManager);

            Console.WriteLine("Sunete de animale");
            DisplayAnimalSounds(animalManager);
            
            string soundOfElephant = animalManager.GetSound("Elefant");
            Console.WriteLine($"Elefantul face sunetul: { soundOfElephant}");

            Console.ReadKey();
        }

        static void PopulateAnimalSounds(AnimalManager animalManager)
        {
            animalManager.AddAnimal("Caine", "Ham");
            animalManager.AddAnimal("Pisica", "Miau");
            animalManager.AddAnimal("Vaca", "Muu");
            animalManager.AddAnimal("Pui", "Piu");
            animalManager.AddAnimal("Rata", "Mac");
            animalManager.AddAnimal("Leu", "Roar");
        }

        static void DisplayAnimalSounds(AnimalManager animalManager)
        {
            foreach (var animalType in animalManager.GetAnimalTypes())
            {
                Console.WriteLine($"{animalType} face sunetul: {animalManager.GetSound(animalType)}");
            }
        }
    }
}
