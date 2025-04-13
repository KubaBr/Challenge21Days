using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge21Days
{
    public class SuperVisor
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
        public SuperVisor(string name, string lastName)

        {
            this.Name = name;
            this.LastName = lastName;
        }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Grade out of the scope");
            }
        }
        public void AddGrade(int grade)
        {
            float result = (int)grade;
            this.AddGrade(result);
        }

        public void AddGrade(string grade)
        {
            int modifier = 0;
            int score = 0;

            if (grade.Contains('+'))
                modifier = 5;
            else if (grade.Contains('-'))
                modifier = -5;

            string temporaryGrade = grade.Trim('+', '-');

            switch (temporaryGrade)
            {
                case "6":
                    score = 100;
                    break;
                case "5":
                    score = 80;
                    break;
                case "4":
                    score = 60;
                    break;
                case "3":
                    score = 40;
                    break;
                case "2":
                    score = 20;
                    break;
                case "1":
                    score = 0;
                    break;
            }
            this.AddGrade(score + modifier);
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
                throw new Exception("Number outside float range");
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
                throw new Exception("Number outside float range");
            }

        }

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;

                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Insert correct letter");

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

            switch (statistics.Avarage)
            {
                case var avarage when avarage >= 80:
                    statistics.AvarageLetter = 'A';
                    break;

                case var avarage when avarage >= 60:
                    statistics.AvarageLetter = 'B';
                    break;
                case var avarage when avarage >= 40:
                    statistics.AvarageLetter = 'C';
                    break;
                case var avarage when avarage >= 20:
                    statistics.AvarageLetter = 'D';
                    break;
                default:
                    statistics.AvarageLetter = 'E';
                    break;

            }


            return statistics;
        }

    }
}
