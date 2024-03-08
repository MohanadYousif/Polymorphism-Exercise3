using PolymorphismExercise.Abstracts;

namespace PolymorphismExercise.Animals
{
    internal class Dog : Animal
    {
        public string Breed { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The dog barks.");
        }
        public override string Stats()
        {
            return $"{base.Stats()}, Breed: {Breed}";
        }
    }
}
