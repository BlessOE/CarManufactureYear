using System;
using System.Text.RegularExpressions;

// Homework Task


// https://stackoverflow.com/questions/4734116/find-and-extract-a-number-from-a-string this link helped me find out how to identify and isolate an int from a string input
// https://www.youtube.com/watch?v=C2zm0roE-Uc this video helped me to understand how to use the regular expressions code line

// asks the user to input their reg plate number
Console.Write("Please enter your car's registration number: ");
int carNum1 = yearOfManufacture();

Console.Write("\nPlease enter your car's registration number: ");
int carNum2 = yearOfManufacture();

Console.Write("\nPlease enter your car's registration number: ");
int carNum3 = yearOfManufacture();


// function that calculates the year a car was manufacture from the car reg plate input
int yearOfManufacture()
{
    // reads the input as a string
    string strInput = Console.ReadLine();
    // finds the string version of the number and stores it in a variable
    string resultString = Regex.Match(strInput, @"\d+").Value;

    // converts the string version of the number to an int
    int carRegNumDigits = Convert.ToInt32(resultString);

    // seperates the two digit int values into 2 different variables
    int firstDigit = carRegNumDigits / 10;
    int secondDigit = carRegNumDigits % 10;


    // calculate what year is was manufactured
    // output the year car was manufactured
    // if statement for when the first digit of the reg number is greater than or equal to 5
    if (firstDigit >= 5)
    {
        int yearOfManufacture = firstDigit - 5;
        Console.WriteLine("Your car was manufactured in 20" + yearOfManufacture + secondDigit);
    }
    // else if statement for when the first digit of the reg number is equal to 0
    else if (firstDigit == 0)
    {
        Console.WriteLine("Your car was manufactured in 200" + carRegNumDigits);
    }
    // else statement for when the first digit of the reg number doesn't meet any of the above requirements
    else
    {
        Console.WriteLine("Your car was manufactured in 20" + carRegNumDigits);
    }

    // returns the number digits
    return carRegNumDigits;
}
