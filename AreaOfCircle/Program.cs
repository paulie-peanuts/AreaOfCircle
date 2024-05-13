// See https://aka.ms/new-console-template for more information
using Helpers;

Console.WriteLine("What is the radius of the circle?");
    // double input = double.Parse(Console.ReadLine());
    // while (Double.IsNaN(input)) {
    //     Console.WriteLine("Bad input!");
    //     break;
    // }
    // string input = Console.ReadLine();
    // double input;
// if (double.TryParse(Console.ReadLine(), out input)) {
//     double radius = double.Parse(Console.ReadLine());
//     while (radius < 0) {
//         // Console.WriteLine("Please do not enter a negative number");
//         Console.WriteLine("What is the radius of the circle?");
//     }
//         radius = double.Parse(Console.ReadLine());
// Console.WriteLine("The area is: " + Circle.Area(radius));

//     }
        // Console.WriteLine("bad");
// Console.WriteLine("What is the radius of the circle?");

//     double radius = double.Parse(Console.ReadLine());

// Console.WriteLine("What is the miles per gallon for your car?");
// double mpg = double.Parse(Console.ReadLine());
// double gallons = Circle.Circumference(radius) / mpg;
// Console.WriteLine("It will take " + gallons + " gallons to go around the circle");
// Console.WriteLine("Here");
double radius;
do {
    Console.WriteLine("Enter");
    string? input = Console.ReadLine() ?? "28";
    if (input == "" || !double.TryParse(input, out double value))
    {
        Console.WriteLine("exit");
        Environment.Exit(0);
    }
    radius = double.Parse(input);
    if (radius < 0)
    {
        Console.WriteLine("no neg");
    }
} while (radius < 0);
Console.WriteLine("The area is: " + Circle.Area(radius));
Console.WriteLine("What is the miles per gallon for your car?");
double mpg = double.Parse(Console.ReadLine());
double gallons = Circle.Circumference(radius) / mpg;
Console.WriteLine("It will take " + gallons + " gallons to go around the circle");