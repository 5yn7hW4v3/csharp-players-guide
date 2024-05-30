// See https://aka.ms/new-console-template for more information

int integer = 2147483647;
short shortInt = 32767;
long longInt = 9_223_372_036_854_775_807;
ushort unsignedShortInt = 65535;
uint unsignedInt = 429496725;
ulong unsignedLongInt = 18446744073709551615;
byte byteInt = 255;
sbyte signedByteInt = -125;
float floatInt = 1.0e-44f;
double doubleInt = 4.2e-320;
decimal decimalInt = 7.9e24m;
char charInt = 'A';
bool boolInt = true;
string stringChar = "A string of chars";

Console.WriteLine($"Integer: {integer}");
Console.WriteLine($"Short: {shortInt}");
Console.WriteLine($"Long: {longInt}");
Console.WriteLine($"Unsigned Short: {unsignedShortInt}");
Console.WriteLine($"Unsigned Int: {unsignedInt}");
Console.WriteLine($"Unsigned Long: {unsignedLongInt}");
Console.WriteLine($"Byte: {byteInt}");
Console.WriteLine($"Signed Byte: {signedByteInt}");
Console.WriteLine($"Float: {floatInt}");
Console.WriteLine($"Double: {doubleInt}");
Console.WriteLine($"Decimal: {decimalInt}");
Console.WriteLine($"Char: {charInt}");
Console.WriteLine($"Bool: {boolInt}");
Console.WriteLine($"String: {stringChar}");
