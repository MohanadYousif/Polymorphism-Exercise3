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
            // Person person = new Person();
            // person.FName = "Mohanad";
            // person.LName = "Yousif";
            // person.Age = 41;
            // person.Weight = 120;

            PersonHandler handler = new PersonHandler();
            Person person = handler.CreatePerson(25, "John", "Doe", 180, 75);
            Console.WriteLine(person.FName);

            List<Person> persons = handler.FindAllPersons();
            persons.ForEach(p => Console.WriteLine(p.FName + " " + p.LName));

            persons = handler.AddNewPerson(person);
            persons.ForEach(p => Console.WriteLine(p.FName + " " + p.LName));

            person = handler.FindPerson(new Person(10, "Mattias", "Olsson", 165, 75.0));
            Console.WriteLine(person.FName);
            
            // 3.2 Polymorfism
            //List<UserError> errors = new List<UserError>
            //{
            //    new NumericInputError(),
            //    new TextInputError()
            //};

            //foreach (var error in errors)
            //{
            //    Console.WriteLine(error.UEMessage());
            //}

            // 3.3 Arv
            List<Animal> animals = new List<Animal>
            {
                new Bird { Name = "Bird", Weight = 1, Age = 2, WingSpan = true},
                new Dog { Name = "Dog", Weight = 30, Age = 3, Breed = "Labrador" },
                new Hedgehog { Name = "Hedgehog", Weight = 2, Age = 3, NrOfSpikes = 1000},
                new Horse { Name = "Horse", Weight = 500, Age = 5, Breed = "Arabian"},
                new Wolf { Name = "Wolf", Weight = 10, Age = 16, SpecieType = "Wild"},
                new Worm { Name = "Worm", Weight = 0.05, Age = 1, IsPoisonous = false},
                new Wolfman { Name = "Wolf man", Weight = 60, Age = 23, SpecieType = "Human wolf"},
                new Flamingo { Name = "Flamingo", Weight = 5, Age = 13, WingSpan = false, Color = "Rosy"},
                new Pelican { Name = "Pelican", Weight = 4, Age = 14, WingSpan = true, IsMigratory = true},
                new Swan { Name = "Swan", Weight = 5, Age = 15, WingSpan = true, IsProtected = true}
            };

            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal.Name);
            //    animal.DoSound();
            //    if (animal is IPerson)
            //        ((IPerson)animal).Talk();

            //}

            //// 3.4 Mer polymorfism (continued)
            //Console.WriteLine("Dog Stats:");
            //foreach (var animal in animals)
            //{
            //    if (animal is Dog)
            //    {
            //        Console.WriteLine(animal.Stats());
            //    }
            //}

            /**
             * 3.3.Arv
             * 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
             *     S: De nya attributen ska läggas till i Bird-klassen så att alla fåglar som ärver från Bird-klassen har tillgång till dessa attribut.
             * 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
             *     S: Ska läggas till i Animal-klassen.
             */

            // 3.4 Mer polymorfism
            //List<Dog> dogs = new List<Dog>
            //{
            //    //new Horse { Name = "Horse", Breed = "Arabian", Weight = 500, Age = 5 },
            //    new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 },
            //    new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 },
            //    new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 },
            //    new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 }
            //};
            /**
             * 09.F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
             *   S: Vi kan lägga till häst till listan över djur på grund av hästklass ärvd djurklass och inte hundklass
             * 10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
             *   S: Listan måste vara av typen Animal-klass
             */

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