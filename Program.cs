using PolymorphismExercise.Abstracts;
using PolymorphismExercise.Animals;
using PolymorphismExercise.Interface;

namespace PolymorphismExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.1 Inkapsling
            // PersonHandler handler = new PersonHandler();
            // Person person = handler.CreatePerson(25, "John", "Doe", 180, 75);
            // Console.WriteLine(person.FName);

            // 3.2 Polymorfism
            List<UserError> errors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError()
            };

            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }

            // 3.3 Arv
            List<Animal> animals = new List<Animal>
            {
                new Horse { Name = "Horse", Breed = "Arabian", Weight = 500, Age = 5 },
                new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 }
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.DoSound();
                if (animal is IPerson)
                {
                    ((IPerson)animal).Talk();
                }
            }

            /**
             * 3.3.Arv
             * 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
             *     S: De nya attributen ska läggas till i Bird-klassen så att alla fåglar som ärver från Bird-klassen har tillgång till dessa attribut.
             * 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
             *     S: Ska läggas till i Animal-klassen.
             */

            // 3.4 Mer polymorfism
            // List<Animal> animals = new List<Animal>
            // {
            //     new Horse { Name = "Horse", Breed = "Arabian", Weight = 500, Age = 5 },
            //     new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 },
            //     new Pelican { Name = "Pelican", IsMigratory = true },
            //     new Flamingo { Name = "Flamingo", Color = "Pink" },
            //     new Swan { Name = "Swan", IsProtected = true }
            // };

            // foreach (var animal in animals)
            // {
            //     Console.WriteLine(animal.Stats());
            // }

            // foreach (var animal in animals.OfType<Dog>())
            // {
            //     Console.WriteLine(animal.CustomMethod());
            // }

        }
    }
}