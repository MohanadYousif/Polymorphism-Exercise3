using PolymorphismExercise.Abstracts;

namespace PolymorphismExercise.Animals
{
    internal class Bird : Animal
    {
        public bool WingSpan { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("All birds Sings");
        }
        public override string Stats()
        {
            return $"{base.Stats}, WingSpan: {WingSpan}";
        }
    }
}
