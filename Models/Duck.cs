using Tema1.Base;

namespace Tema1.Models
{
    public class Duck : Animal, IAnimal
    {
        public Duck()
        {
            SetType<Duck>();
            SetSound("mac");
        }
    }
}