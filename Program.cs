Console.WriteLine("Podaj liczbe: ");

string userInput = Console.ReadLine();

int number = int.Parse(userInput);

bool isDivisibledFirst = number % 3 == 0;

bool isDivisibledSecond = number % 7 == 0;

if (isDivisibledFirst && isDivisibledSecond)
{
    Console.WriteLine($"Liczba {number} jest podzielna przez 3 i 7");
}

//Sprawdzić czy podana liczba jest podzielna przez 3 i 7.