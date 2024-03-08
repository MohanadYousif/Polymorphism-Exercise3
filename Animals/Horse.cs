using PolymorphismExercise.Abstracts;

namespace PolymorphismExercise.Animals
{
    internal class Horse : Animal
    {
        public string Breed { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Breed: {Breed}";
        }
    }
}
