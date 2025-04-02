using Challenge21Days;

Employee user1 = new Employee("Kuba", "Kubański",30);
Employee user2 = new Employee("Ewa", "Nowak",24);
Employee user3 = new Employee("Włodek", "Kowal", 33);

int maxValue = int.MinValue;
Employee userName = null;

List<Employee> Users = new List<Employee>() { user1, user2, user3 };

user1.AddGrade(5);
user1.AddGrade(7);
user1.AddGrade(3);
user1.AddGrade(8);
user1.AddGrade(5);

user2.AddGrade(8);
user2.AddGrade(7);
user2.AddGrade(4);
user2.AddGrade(3);
user2.AddGrade(10);

user3.AddGrade(9);
user3.AddGrade(9);
user3.AddGrade(1);
user3.AddGrade(2);
user3.AddGrade(3);

foreach (var user in Users)
{
    if (maxValue < user.Result)
    {
        maxValue = user.Result;
        userName = user;
    }
}

Console.WriteLine($"Użytkownik: {userName.Name} {userName.LastName}, wiek {userName.Age}, uzyskał najwyższy wynik! Jest to: {userName.Result}");