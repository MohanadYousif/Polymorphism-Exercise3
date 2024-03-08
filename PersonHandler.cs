
namespace PolymorphismExercise
{
    internal class PersonHandler
    {
        internal void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        internal Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            person.Age = age;
            person.FName = fname;
            person.LName = lname;
            person.Height = height;
            person.Weight = weight;
            return person;
        }

        internal List<Person> FindAllPersons()
        {
            List<Person> persons = new List<Person>{
                CreatePerson(10, "Mohanad", "Yousif", 179.8, 125.0),
                CreatePerson(10, "Fadi", "Nabil", 175.0, 80.0),
                CreatePerson(10, "Mark", "Eriksson", 185.0, 99.20),
                CreatePerson(10, "Mattias", "Olsson", 165, 75.0)
            };
            return persons;
        }
        internal List<Person> AddNewPerson(Person person){
            List<Person> personList = new PersonHandler().FindAllPersons();
            personList.Add(person);
            return personList;
        }

        internal Person FindPerson(Person person)
        {
            return new PersonHandler().FindAllPersons().Find(p => p.Equals(person));
        }        

        internal Person UpdatePerson(Person person, int? age, string fName, string lName, double? height, double? weight)
        {
            Person updatePerson = new PersonHandler().FindPerson(person);

            if (age.HasValue)
            {
                updatePerson.Age = (int)age;
            }

            if (!String.IsNullOrEmpty(fName) || !String.IsNullOrWhiteSpace(fName))
            {
                updatePerson.FName = fName;
            }

            if (!String.IsNullOrEmpty(lName) || !String.IsNullOrWhiteSpace(lName))
            {
                updatePerson.LName = lName;
            }

            if (height.HasValue)
            {
                updatePerson.Height = (double)height;
            }

            if (weight.HasValue)
            {
                updatePerson.Weight = (double)weight;
            }
            
            return updatePerson;
        }

        internal void RemovePeron(Person person)
        {
            new PersonHandler().FindAllPersons().Remove(person);
        }


    }
}
