
namespace PolymorphismExercise
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                age = value > 0 ? value : throw new ArgumentException("Age must be greater than 0.");
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                fName = !(String.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10) ? value :
                    throw new ArgumentException("First name must be between 2 and 10 characters.");
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                lName = !(String.IsNullOrEmpty(value) || value.Length < 3 || value.Length > 15) ? value :
                    throw new ArgumentException("Last name must be between 3 and 15 characters.");
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }


}
