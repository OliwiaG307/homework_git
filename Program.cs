Console.WriteLine("Napisz zdanie:");
string userInput = Console.ReadLine();

if (userInput.Length >= 4)
{
    Console.WriteLine(userInput.Substring(userInput.Length - 4) + userInput.Substring(userInput.Length - 4) + userInput.Substring(userInput.Length - 4) + userInput.Substring(userInput.Length - 4));
}
else
{
    Console.WriteLine(userInput.Length < 4 ? userInput + userInput + userInput);
}

//Write a C# program to create a string of four copies, taking the last four characters from a given string.
//If the given string is less than 4, return the original one.