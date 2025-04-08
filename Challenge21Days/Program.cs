using Challenge21Days;

Employee user1 = new Employee("Kuba", "Kubański");

Console.WriteLine("Witamy w Programie Alfabetus do oceny Pracowników");
Console.WriteLine("=================================================\n");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    user1.AddGrade(input);
}

var statistic = user1.GetStatistics();
Console.WriteLine($"Max: {statistic.Max}");
Console.WriteLine($"Min: {statistic.Min}");
Console.WriteLine($"Avarage: {statistic.Avarage:N2}");
Console.WriteLine($"AvarageLetter: {statistic.AvarageLetter}");
