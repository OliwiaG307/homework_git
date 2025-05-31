Console.WriteLine("Napisz słowo lub zdanie:");
string userInput = Console.ReadLine();

if (userInput.Length >= 1)
{
    string letter = userInput.Substring(0, 1);
    Console.WriteLine(letter + userInput + letter);
}

//Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.