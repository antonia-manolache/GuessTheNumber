// See https://aka.ms/new-console-template for more information

using System.Globalization;

var lowerLimit = new int();
var upperLimit = new int();

var randomNumber = new int();
var guessedNumber = new int();

var random = new Random();

bool CheckBoundaries(int lowerLimit, int upperLimit)
{
    return lowerLimit <= upperLimit;
}

void ValidateBoundaries()
{
    bool isUpperLimitOk = false;
    while(!isUpperLimitOk)
    {
        if(!CheckBoundaries(lowerLimit, upperLimit))
        {
            Console.WriteLine("The upper limit is less than the lower limit. Insert lower limit again: ");
            ReadUpperLimit();
        }
        else
        {
            isUpperLimitOk = true;
        }
    }
}

void ReadLowerLimit()
{
    bool isLimitValid = false;
    string value;

   
   
    while(!isLimitValid)
    {
        Console.WriteLine("Insert the lower limit of the range: ");
        value = Console.ReadLine();
        if(int.TryParse(value, out lowerLimit))
        {
            isLimitValid = true;

        }
        else
        {
            Console.WriteLine("Invlid limit!");
        }

    }

}

void ReadUpperLimit()
{
    bool isLimitValid = false;
    string value;



    while (!isLimitValid)
    {
        Console.WriteLine("Insert the upper limit of the range: ");
        value = Console.ReadLine();
        if (int.TryParse(value, out upperLimit))
        {
            isLimitValid = true;

        }
        else
        {
            Console.WriteLine("Invlid limit!");
        }

    }

}

void ReadGuessedNumber()
{
    bool isNumberValid = false;
    string value;



    while (!isNumberValid)
    {
        value = Console.ReadLine();
        if (int.TryParse(value, out guessedNumber))
        {
            isNumberValid = true;

        }
        else
        {
            Console.WriteLine("Invlid guess! Please insert an int value: ");
        }

    }


}

void GenerateRandomNumber()
{
    Console.WriteLine("I am thinking of a number between " + lowerLimit + " and " + upperLimit + ". Try and guess it");
    randomNumber = random.Next(lowerLimit, upperLimit);
}

void KeepGuessing()
{
    ReadGuessedNumber();

    while (guessedNumber != randomNumber)
    {
        if (guessedNumber < randomNumber)
        {
            Console.WriteLine("Number " + guessedNumber + " is too low. Please try again!");
            ReadGuessedNumber();
        }
        else
        {
            Console.WriteLine("Number " + guessedNumber + " is too high. Please try again!");
            ReadGuessedNumber();
        }
    }

    Console.WriteLine("Congratulation! " + guessedNumber + " is the number I was thinking about.");
}


ReadLowerLimit();
ReadUpperLimit();

ValidateBoundaries();

GenerateRandomNumber();

KeepGuessing();