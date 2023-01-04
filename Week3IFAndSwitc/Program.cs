using System;

Console.WriteLine("Fahrenheit to Celsius (A) or Celsius to Fahrenheit? (B)");

char userOperator = char.Parse(Console.ReadLine());



Console.WriteLine("Enter the number you wish to transfer");

int Num = Int32.Parse(Console.ReadLine());


switch (userOperator)

{
    case 'A':

        FahrenheitToCelsius(Num);

        break;
    case 'B':

        CelsiusToFahrenheit(Num);

        break;

    default:

        Console.WriteLine("Invalid operator");

        break;

}





static void FahrenheitToCelsius(int a)

{

    Console.WriteLine($"{(a - 32) * 5 / 9}");

}

static void CelsiusToFahrenheit(int a)

    {

        Console.WriteLine($"{(a * 9) / 5 + 32}");

}



