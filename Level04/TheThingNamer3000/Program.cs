// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");

// string A sets the "thing" that the user is talking about
string a = Console.ReadLine();

Console.WriteLine("How would you describe it? Big? Azure? Tattered?");

/* string B sets the description of the "thing"
    that the user is talking about*/
string b = Console.ReadLine();
string c = " of Doom";
string d = "3000";
Console.WriteLine("The " + b + " " + a + c + " " + d + "!");