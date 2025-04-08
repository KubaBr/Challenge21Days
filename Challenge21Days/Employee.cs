using System.Diagnostics;

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
        public Statistics GetStatisticsFor()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;



            for(var index = 0; index < grades.Count; index++)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Avarage += grades[index];

            }
            statistics.Avarage /= this.grades.Count;


            return statistics;
        }       
        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Avarage += grades[index];
                index++;
            } while (index < grades.Count);

            statistics.Avarage /= this.grades.Count;


            return statistics;
        }  
        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();
            statistics.Avarage = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            var index = 0;

            while (index < grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, grades[index]);
                statistics.Min = Math.Min(statistics.Min, grades[index]);
                statistics.Avarage += grades[index];
                index++;
            } 

            statistics.Avarage /= this.grades.Count;


            return statistics;
        }


        //metoda GetStatistics dla foreach,
        //metoda GetStatistics dla for
        //metoda GetStatistics dla doWhile
        //metoda GetStatistics dla while


    }
}
