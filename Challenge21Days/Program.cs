using Challenge21Days;

Employee user1 = new Employee("Kuba", "Kubański");
Employee user2 = new Employee("Ewa", "Nowak");
Employee user3 = new Employee("Włodek", "Kowal");

long test = 10;
user1.AddGrade("Kuba");
user1.AddGrade(7);
user1.AddGrade(3);
user1.AddGrade(test);

var statistic = user1.GetStatistics();
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Avarage: {statistic.Avarage:N2}");

