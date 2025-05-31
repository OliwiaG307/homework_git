Console.WriteLine("Podaj pierwszą liczbę do pomnożenia:");
string firstUserInput = Console.ReadLine();
int firstNumber = int.Parse(firstUserInput);

Console.WriteLine("Podaj drugą liczbę do pomnożenia:");
string secondUserInput = Console.ReadLine();
int secondNumber = int.Parse(secondUserInput);

Console.WriteLine("Podaj trzecią liczbę do pomnożenia:");
string thirdUserInput = Console.ReadLine();
int thirdNumber = int.Parse(thirdUserInput);

int numberMultiplied = firstNumber + secondNumber + thirdNumber;

Console.WriteLine($"Twój wynik to: {numberMultiplied}");

//Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.