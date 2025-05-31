Console.WriteLine("Podaj dowolny znak, literę lub liczbę:");
string userInput = Console.ReadLine();
string lowerCaseInputValue = userInput.ToLower();

string vowels = "aąeęiouóy";
string consonant = "bcćdfghjklłmnńprsśtwyzźż";
string sign = "@#$%&*()_-=+{}[]|:;'<>,.!?/~`^";

if (vowels.Contains(lowerCaseInputValue))
{
    Console.WriteLine($"{lowerCaseInputValue} jest samogłoską");
}
else if (consonant.Contains(lowerCaseInputValue))
{
    Console.WriteLine($"{lowerCaseInputValue} jest spółgłoską");
}
else if (sign.Contains(lowerCaseInputValue))
{
    Console.WriteLine($"{lowerCaseInputValue} jest znakiem");
}
else
{
    Console.WriteLine($"{lowerCaseInputValue} jest cyfrą");
}


//Sprawdź, czy wpisany znak to samogłoska, spółgłoska, cyfra czy inny znak. 