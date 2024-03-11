using PolymorphismExercise.Abstracts;
using PolymorphismExercise.Animals;
using PolymorphismExercise.Errors;
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
            Console.WriteLine("The new person is " + person.FName + "\n");

            List<Person> persons = handler.FindAllPersons();
            persons.ForEach(p => Console.WriteLine(p.FName + " " + p.LName));
            Console.Write("\n");

            persons = handler.AddNewPerson(person);
            persons.ForEach(p => Console.WriteLine(p.FName + " " + p.LName));

            Person person1 = new Person(10, "Mattias", "Olsson", 165, 75.0);
            Person findPerson = handler.FindPerson(person1);
            Console.WriteLine(Object.ReferenceEquals(findPerson, null) ? "\nNothing to show.\n" : "\nWe found " + findPerson.FName + "\n");

            Person person2 = new Person(10, "Mohanad", "Yousif", 179.8, 125.0);
            Person UPerson = handler.UpdatePerson(person2, 0, "Muhannad", "Aziz", 185, 80);
            Console.WriteLine($"befor update: {person2.Age}, {person2.FName}, {person2.LName}, {person2.Height}, {person2.Weight}");
            Console.WriteLine($"after update: {UPerson.Age}, {UPerson.FName}, {UPerson.LName}, {UPerson.Height}, {UPerson.Weight}\n");

            handler.RemovePeron(person);
            findPerson = handler.FindPerson(person);
            Console.WriteLine(Object.ReferenceEquals(findPerson, null) ? "\nRemoved successfully\n" : "\nWe found " + findPerson.FName + "\n");

            //3.2 Polymorfism
            // 7. I Program.cs Main-metod: Skapa en lista med UserErrors och populera den med
            // instanser av NumericInputError, TextInputError och de nya klasserna.
            List<UserError> errors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new ConnectionError(),
                new FileReadError(),
                new DatabaseError()
            };
            // 8. Skriv ut samtliga UserErrors UEMessage() genom en foreach loop.
            foreach (var error in errors)
            {
                Console.WriteLine(error.UEMessage());
            }
            Console.WriteLine();


            // 3.3 Arv och 3.4 Mer polymorfism (continued)
            List<Animal> animals = new List<Animal>
            {
                new Bird { Name = "Bird", Weight = 1, Age = 2, WingSpan = true},
                new Dog { Name = "Dog", Weight = 30, Age = 3, Breed = "Labrador" },
                new Hedgehog { Name = "Hedgehog", Weight = 2, Age = 3, NrOfSpikes = 1000},
                new Horse { Name = "Horse", Weight = 500, Age = 5, MaxSpeed = "50 km/h"},
                new Wolf { Name = "Wolf", Weight = 10, Age = 16, SpecieType = "Wild"},
                new Worm { Name = "Worm", Weight = 0.05, Age = 1, IsPoisonous = false},
                new Wolfman { Name = "Wolf man", Weight = 60, Age = 23, SpecieType = "Human wolf"},
                new Flamingo { Name = "Flamingo", Weight = 5, Age = 13, WingSpan = false, Color = "Rosy"},
                new Pelican { Name = "Pelican", Weight = 4, Age = 14, WingSpan = true, IsMigratory = true},
                new Swan { Name = "Swan", Weight = 5, Age = 15, WingSpan = true, IsProtected = true}
            };

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
                animal.DoSound();
                if (animal is IPerson)
                    ((IPerson)animal).Talk();
                else if (animal is Dog)
                    Console.WriteLine(animal.Stats() + "\n");
                else Console.WriteLine("");

            }

            /**
             * 3.3.Arv
             * 13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
             *     S: De nya attributen ska läggas till i Bird-klassen så att alla fåglar som ärver från Bird-klassen har tillgång till dessa attribut.
             * 14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
             *     S: Ska läggas till i Animal-klassen.
             */

            // 3.4 Mer polymorfism
            List<Dog> dogs = new List<Dog>
            {
                //new Horse { Name = "Horse", Breed = "Arabian", Weight = 500, Age = 5 },
                new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 },
                new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 },
                new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 },
                new Dog { Name = "Dog", Breed = "Labrador", Weight = 30, Age = 3 }
            };
            /**
             * 09.F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
             *   S: Vi kan lägga till häst till listan över djur på grund av hästklass ärvd djurklass och inte hundklass
             * 10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
             *   S: Listan måste vara av typen Animal-klass
             */

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            //  16. Nej, klassen Animal kan inte direkt komma åt några metoder eller egenskaper i klassen Dog.
            //  17. Arv tillåter underklasser (som Dog) att komma åt medlemmar (egenskaper, metoder)
            //      i deras basklass (Animal), men inte tvärtom. Basklassen (Animal) har ingen kunskap
            //      om sina underklassers specifika medlemmar eller metoder.

            // 18. Genom att casta Animal class till Dog kan vi få tillgång till CustomMethod, men det rekommenderas inte
            Animal newAnimal = new Dog();
            if (newAnimal is Dog)
            {
                Dog dog = (Dog)newAnimal; // Casting the Animal instance to Dog
                string result = dog.CustomMethod(); // Accessing CustomMethod from Dog class
                Console.WriteLine("Casting: " + result); // Output: hello from dog's class
            }

            // 18. Genom att använda LINQs OfType<T>()-metod för att filtrera en samling djur
            // och bara välja de som är av typen Dog. Sedan itererar den över varje Dog-instans
            // i den filtrerade samlingen och anropar CustomMethod() för varje Dog-instans.
            foreach (var animal in animals.OfType<Dog>())
            {
                Console.WriteLine("LINQs: " + animal.CustomMethod());
            }

        }
    }
}