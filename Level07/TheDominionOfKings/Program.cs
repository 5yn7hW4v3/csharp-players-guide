// See https://aka.ms/new-console-template for more information

int estate = 1;
int duchy = 3;
int province = 6;

Console.Write("Enter the number of Estates: ");
String estateString = Console.ReadLine();
Console.Write("Enter the number of Duchies: ");
String duchyString = Console.ReadLine();
Console.Write("Enter the number of Provinces: ");
String provinceString = Console.ReadLine();

int estateInt = Convert.ToInt32(estateString);
int duchyInt = Convert.ToInt32(duchyString);
int provinceInt = Convert.ToInt32(provinceString);

int totalPoints = (estate * estateInt) + (duchy * duchyInt) + (province * provinceInt);

Console.WriteLine($"Total Points: {totalPoints}");