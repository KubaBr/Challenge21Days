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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Grade out of the scope");
            }
        }
        public void AddGrade(int grade)
        {
            float result = (int)grade;
            this.AddGrade(result);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not possible to convert");
            }
        }

        public void AddGrade(double grade)
        {
            if (grade <= float.MaxValue && grade >= float.MinValue)
            {
                float result = (float)grade;
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Number outside float range");
            }

        }

        public void AddGrade(long grade)
        {

            if (grade <= float.MaxValue && grade >= float.MinValue)
            {
                float result = (float)grade;
                this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("Number outside float range");
            }

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
