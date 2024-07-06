using Tema1.Base;

namespace Tema1.Models
{
    public class Dog : Animal, IAnimal
    {
        public Dog()
        {
            SetType<Dog>();
            SetSound("ham");
        }
    }
}
