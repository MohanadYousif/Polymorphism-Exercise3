namespace PolymorphismExercise.Animals
{
    internal class Swan : Bird
    {
        public bool IsProtected { get; set; }

        public override string Stats()
        {
            return $"{base.Stats()}, Protected: {IsProtected}";
        }
    }
}
