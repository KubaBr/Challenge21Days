using Challenge21Days;

Employee user1 = new Employee("Kuba", "oasu89346DG4$");
Employee user2 = new Employee("Ewa", "qw23erty77u");
Employee user3 = new Employee("Włodek", "asdttBB4@@4");

int maxValue = int.MinValue;
string userName = null;

List<Employee> Users = new List<Employee>() { user1, user2, user3 };

user1.AddGrade(5);
user1.AddGrade(7);
user1.AddGrade(3);

user2.AddGrade(8);
user2.AddGrade(7);
user2.AddGrade(4);

user3.AddGrade(9);
user3.AddGrade(9);
user3.AddGrade(10);

foreach (var user in Users)
{
    if (maxValue < user.Result)
    {
        maxValue = user.Result;
        userName = user.Login;
    }
}

Console.WriteLine($"Użytkownik: {userName}, uzyskał najwyższy wynik! Jest to: {maxValue}");