using Tema1.Base;

namespace Tema1.Models
{
    public class Cat : Animal, IAnimal
    {
        public Cat()
        {
            SetType<Cat>();
            SetSound("meow");
        }
    }
}
