using Tema1.Base;

namespace Tema1.Models
{
    public class Lion : Animal, IAnimal
    {
        public Lion()
        {
            SetType<Lion>();
            SetSound("roar");
        }
    }
}