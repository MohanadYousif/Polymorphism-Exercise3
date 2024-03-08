namespace PolymorphismExercise.Animals
{
    internal class Flamingo : Bird
    {
        public string Color { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Color: {Color}";
        }
    }

}
