Console.WriteLine("Podaj liczbę:");
string firstUserInput = Console.ReadLine();
int firstNumber = int.Parse(firstUserInput);

Console.WriteLine("Podaj drugą liczbę:");
string secondUserInput = Console.ReadLine();
int secondNumber = int.Parse(secondUserInput);

bool sum = firstNumber + secondNumber;
Console.WriteLine($"Suma tych dwóch liczb wynosi {sum}.");

// Write a C# Sharp program to print the sum of two numbers.