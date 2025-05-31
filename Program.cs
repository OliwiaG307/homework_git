Console.WriteLine("Podaj liczbę:");
string userInput = Console.ReadLine();
int number = int.Parse(userInput);

switch (number)
{
    case 1:
        Console.WriteLine("poniedziałek");
        break;
    case 2:
        Console.WriteLine("wtorek");
        break;
    case 3:
        Console.WriteLine("środa");
        break;
    case 4:
        Console.WriteLine("czwartek");
        break;
    case 5:
        Console.WriteLine("piątek");
        break;
    case 6:
        Console.WriteLine("sobota");
        break;
    case 7:
        Console.WriteLine("niedziela");
        break;
    default:
        Console.WriteLine("nie ma takiego dnia tygodnia");
        break;
}