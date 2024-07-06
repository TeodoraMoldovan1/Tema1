using Tema1.Base;

namespace Tema1.Models
{
    public class Frog : Animal, IAnimal
    {
        public Frog()
        {
            SetType<Frog>();
            SetSound("oac");
        }
    }
}