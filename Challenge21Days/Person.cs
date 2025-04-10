
namespace Challenge21Days
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Person (string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }  

    }
}
