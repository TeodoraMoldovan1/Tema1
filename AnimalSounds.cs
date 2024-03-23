using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    public class AnimalManager
    {
        // Dictionar utilizat pentru asocierea animalelor si a sunetelor 
        private Dictionary<string, string> animalSounds = new Dictionary<string, string>();


        // Adaugarea unui nou animal in dictionar
        public void AddAnimal(string type, string sound)
        {
            animalSounds[type] = sound;
        }

        // Returnarea tuturor elementelor din dictionar
        public Dictionary<string, string> GetAnimalSounds()
        {
            return animalSounds;
        }

        // Metoda pentru a obtine toate tipurile de animale - cheile dictionarului
        public IEnumerable<string> GetAnimalTypes()
        {
            return animalSounds.Keys;
        }


        // Metoda pentru a obtine sunetele animalelor
        public string GetSound(string type)
        {
            if (animalSounds.ContainsKey(type))
                return animalSounds[type];
            else
                return "Sunetul nu a fost inregistrat";
        }
    }
}
