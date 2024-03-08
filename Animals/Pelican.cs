namespace PolymorphismExercise.Animals
{
    internal class Pelican : Bird
    {
        public bool IsMigratory { get; set; }

        public override string Stats()
        {
            return $"{base.Stats}, Migratory: {IsMigratory}";
        }
    }

}
