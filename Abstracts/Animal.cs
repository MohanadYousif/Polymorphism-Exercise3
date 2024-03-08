namespace PolymorphismExercise.Abstracts
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public abstract void DoSound();

        public virtual string Stats()
        { 
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }
    }
}
