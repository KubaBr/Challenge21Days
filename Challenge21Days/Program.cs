using Challenge21Days;

Employee user1 = new Employee("Kuba", "Kubański");
SuperVisor super1 = new SuperVisor("Wojtek", "Wojciechowski");

Console.WriteLine("Witamy w Programie Alfabetus do oceny Pracowników");
Console.WriteLine("=================================================\n");

super1.AddGrade("+5");

//while (true)
//{
//    Console.WriteLine("Podaj kolejną ocenę pracownika: ");
//    var input = Console.ReadLine();
//    if(input == "q")
//    {
//        break;
//    }
//    try
//    {
//        user1.AddGrade(input);
//    }
//    catch(Exception e)
//    {
//        Console.WriteLine($"Exception cateched: {e.Message}");
//    }
    
//}

//var statistic = user1.GetStatistics();
//Console.WriteLine($"Max: {statistic.Max}");
//Console.WriteLine($"Min: {statistic.Min}");
//Console.WriteLine($"Avarage: {statistic.Avarage:N2}");
//Console.WriteLine($"AvarageLetter: {statistic.AvarageLetter}\n");

var statistic1 = super1.GetStatistics();
Console.WriteLine($"Max super: {statistic1.Max}");
Console.WriteLine($"Min super: {statistic1.Min}");
Console.WriteLine($"Avarage super: {statistic1.Avarage:N2}");
Console.WriteLine($"AvarageLetter super: {statistic1.AvarageLetter}");
