using Challenge21Days;

Employee user1 = new Employee("Kuba", "Kubański");
Employee user2 = new Employee("Ewa", "Nowak");
Employee user3 = new Employee("Włodek", "Kowal");

long test = 10;
user1.AddGrade("Kuba");
user1.AddGrade(7);
user1.AddGrade(3);
user1.AddGrade(test);


Console.WriteLine("Foreach:");
var statistic = user1.GetStatistics();
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Avarage: {statistic.Avarage:N2}");

Console.WriteLine("\nFor:");
var statistic1 = user1.GetStatisticsFor();
Console.WriteLine($"Max: {statistic1.Max}");
Console.WriteLine($"Min: {statistic1.Min}");
Console.WriteLine($"Avarage: {statistic1.Avarage:N2}");

Console.WriteLine("\nDoWhile:");
var statistic2 = user1.GetStatisticsDoWhile();
Console.WriteLine($"Max: {statistic2.Max}");
Console.WriteLine($"Min: {statistic2.Min}");
Console.WriteLine($"Avarage: {statistic2.Avarage:N2}");

Console.WriteLine("\nWhile:");
var statistic3 = user1.GetStatisticsWhile();
Console.WriteLine($"Max: {statistic3.Max}");
Console.WriteLine($"Min: {statistic3.Min}");
Console.WriteLine($"Avarage: {statistic3.Avarage:N2}");

