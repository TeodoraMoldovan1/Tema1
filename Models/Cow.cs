using Tema1.Base;

namespace Tema1.Models
{
    public class Cow : Animal, IAnimal
    {
        public Cow()
        {
            SetType<Cow>();
            SetSound("mu");
        }
    }
}