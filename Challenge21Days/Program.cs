string name = "Michal";
char sex = 'M';
int age = 17;

if(sex == 'K' && age <30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30.");
}
else if(sex == 'M' && age < 18)
{
    Console.WriteLine("Niepełnoletni meżczyzna.");
}
else
{
    Console.WriteLine("Żaden z powyższych warunków, nie został spełniony");
}