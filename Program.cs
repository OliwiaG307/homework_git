Console.WriteLine("Podaj samogłoskę");

string userInput = Console.ReadLine();
string lowerCaseInputValue = userInput.ToLower();
string vowels = "aąeęiouóy";

bool isVowel = vowels.Contains(lowerCaseInputValue);

if (isVowel)
{
    Console.WriteLine($"Podana litera {lowerCaseInputValue} jest samogłoską");
}

//Sprawdzić czy podana litera jest samogłoską