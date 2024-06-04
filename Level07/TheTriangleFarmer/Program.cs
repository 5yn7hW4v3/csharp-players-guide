// See https://aka.ms/new-console-template for more information

string triangleBaseString;
string triangleHeightString;
double triangleBaseDouble;
double triangleHeightDouble;
double triangleArea;


Console.Write("Triangle Base: ");
triangleBaseString = Console.ReadLine();
Console.Write("Triangle Height: ");
triangleHeightString = Console.ReadLine();

triangleBaseDouble = Convert.ToDouble(triangleBaseString);
triangleHeightDouble = Convert.ToDouble(triangleHeightString);

triangleArea = (triangleBaseDouble * triangleHeightDouble) / 2;

Console.WriteLine($"Triangle Area: {triangleArea}");
