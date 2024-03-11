using PolymorphismExercise.Abstracts;

namespace PolymorphismExercise.Animals
{
    internal class Horse : Animal
    {
        public string MaxSpeed { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The horse neighs");
        }

        public override string Stats()
        {
            return $"{base.Stats()}, Max Speed: {MaxSpeed}";
        }
    }
}
