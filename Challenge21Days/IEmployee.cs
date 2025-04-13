namespace Challenge21Days
{
    public interface IEmployee
    {
        string Name { get;  }
        string LastName { get;  } 
        Statistics GetStatistics();
        void AddGrade(float grade);
        void AddGrade(int grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(char grade);


    }
}
