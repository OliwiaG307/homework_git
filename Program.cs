Console.WriteLine("Podaj masę ciała:");
string weight = Console.ReadLine();
double numberOne = double.Parse(weight);

Console.WriteLine("Podaj wzrost:");
string height = Console.ReadLine();
double numberTwo = double.Parse(height);

double theBMI = numberOne / (numberTwo * numberTwo) * 10000;
Console.WriteLine($"Twoje BMI to: {theBMI}");

if (theBMI < 18.5)
{
    Console.WriteLine("niedowaga");
}
else if (theBMI >= 18.5 && theBMI < 25)
{
    Console.WriteLine("prawidłowa waga");
}
else if (theBMI >= 25 && theBMI < 30)
{
    Console.WriteLine("nadwaga");
}
else if (theBMI >= 30)
{
    Console.WriteLine("otyłość");
}

//Program to mierzenia BMI