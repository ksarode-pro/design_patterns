namespace Evolent.Evolent
{

    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + "," + this.LastName;
        }
    }

    public class PersonHandler
    {

        public string GetPersons()
        {
            Person[] person = new Person[] { new Person("John", "Smith"), new Person("Amy", "Smith") };

            string names = "";
            for (int i = 0; i < person.Length; i++)
            {
                names += person[i].ToString() + " ";
            }
            return names;
        }
    }

}