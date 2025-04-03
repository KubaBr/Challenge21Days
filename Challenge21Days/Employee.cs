namespace Challenge21Days
{
    public class Employee
    {
        List<int> Scores = new List<int>();

        private int score = 0;
        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public int Result
        {
            get
            {
                return this.Scores.Sum();
            }
        }
        public Employee(string name, string lastName, int age)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Age = age;
        }
        public Employee(string name)
        {
            this.Name = name;
            this.LastName = "Brak nazwiska";
            this.Age = 0;
        }

        public void AddGrade(int score)
        {
            this.Scores.Add(score);
        }
    }
}
