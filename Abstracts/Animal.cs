namespace PolymorphismExercise.Abstracts
{
    //  3.3) Arv
    //    1. Skapa abstrakta klassen Animal
    internal abstract class Animal
    {
        // 4. Lägg till en konstruktor
        internal Animal() { }

        //  2. Fyll klassen Animal med egenskaper (properties) som alla djur bör ha. Tex namn, vikt, ålder.
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        //  3. Skapa en abstrakt metod som heter DoSound().
        public abstract void DoSound();
        public virtual string Stats()
        {
            return $"Name: {Name}, Weight: {Weight}, Age: {Age}";
        }
    }
}
