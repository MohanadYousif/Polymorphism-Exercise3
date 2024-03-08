using PolymorphismExercise.Animals;
using PolymorphismExercise.Interface;

namespace PolymorphismExercise
{
    internal class Wolfman : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine("I'm a Wolfman");
        }
    }
}
