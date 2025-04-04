namespace Challenge21Days
{
    public class Employee
    {
        List<float> grades = new List<float>();


        public string Name { get; private set; }
        public string LastName { get; private set; }


        public float Result
        {
            get
            {
                return this.grades.Sum();
            }
        }
        public Employee(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
        public Employee(string name)
        {
            this.Name = name;
            this.LastName = "Brak nazwiska";

        }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();

            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Avarage += grade;

            }
            statistics.Avarage /= this.grades.Count;

            return statistics;
        }

        //testy do usera z uwzględnieniem statystyk,
        //testy sprawdzająca, czy metoda zwracająca statystki działa prawidłow,
        //



    }
}
