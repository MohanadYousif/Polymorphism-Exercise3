
using PolymorphismExercise.Abstracts;

namespace PolymorphismExercise.Animals
{
    internal class Wolf : Animal
    {
        public string SpecieType { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The wolf howl");
        }
        public override string Stats()
        {
            return $"{base.Stats()}, Specie: {SpecieType}";
        }
    }
}
