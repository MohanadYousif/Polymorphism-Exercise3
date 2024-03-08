
using PolymorphismExercise.Abstracts;

namespace PolymorphismExercise.Animals
{
    internal class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The hedgehog purr");
        }

        public override string Stats()
        {
            return $"{base.Stats}, NrOfSpikes: {NrOfSpikes}";
        }
    }
}
