// See https://aka.ms/new-console-template for more information

var lowerLimit = new int();
var upperLimit = new int();

var randomNumber = new int();
var guessedNumber = new int();

var random = new Random();

Console.WriteLine("Insert the lower limit of the range: ");
lowerLimit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Insert the upper limit of the range: ");
upperLimit = Convert.ToInt32(Console.ReadLine());

randomNumber = random.Next(lowerLimit, upperLimit);

Console.WriteLine("I am thinking of a number between " + lowerLimit + " and " + upperLimit + ". Try and guess it");

guessedNumber = Convert.ToInt32(Console.ReadLine());

while (guessedNumber != randomNumber)
{
    if (guessedNumber < randomNumber)
    {
        Console.WriteLine("Number " + guessedNumber + " is too low. Please try again!");
        guessedNumber = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Number " + guessedNumber + " is too high. Please try again!");
        guessedNumber = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Congratulation! " + guessedNumber + " is the number I was thinking about.");

