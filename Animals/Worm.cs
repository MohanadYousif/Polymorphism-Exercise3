
using PolymorphismExercise.Abstracts;

namespace PolymorphismExercise.Animals
{
    internal class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The worm has no voice");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Is Poisonous: {IsPoisonous}";
        }
    }
}
