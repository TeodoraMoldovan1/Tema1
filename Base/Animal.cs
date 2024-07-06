using System;
using Tema1.Base;

namespace Tema1
{
    public abstract class Animal : IAnimal
    {
        protected string Type { get; set; } = string.Empty;
        protected string Sound { get; set; } = string.Empty;

        protected void SetType<T>() where T : class
        {
            Type = typeof(T).Name;
        }

        protected void SetSound(string sound)
        {
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Type} makes the sound: {Sound}");
        }
    }
}
