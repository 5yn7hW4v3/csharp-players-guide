
string numberOfChocolateEggsString;

Console.WriteLine("How many chocolate eggs were collected?");
numberOfChocolateEggsString = Console.ReadLine();

int numberOfChocolateEggs = Convert.ToInt32(numberOfChocolateEggsString);

int sisterEggs = numberOfChocolateEggs / 3;
int duckBearEggs = numberOfChocolateEggs % 3;

Console.WriteLine("Each Sister gets " + sisterEggs + " eggs.");
Console.WriteLine("The DuckBear gets " + duckBearEggs + " eggs.");