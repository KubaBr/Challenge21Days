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
        public Employee(string login, string lastName, int age)
        {
            this.Name = login;
            this.LastName = lastName;
            this.Age = age;
        }

        public void AddGrade(int score)
        {
            this.Scores.Add(score);
        }
    }
}
