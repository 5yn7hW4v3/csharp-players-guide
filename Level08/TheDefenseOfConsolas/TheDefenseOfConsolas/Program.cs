
Console.Write("Target Row? ");
string targetRowString = Console.ReadLine();
Console.Write("Target Column? ");
string targetColumnString = Console.ReadLine();

int targetRowInt = Convert.ToInt32(targetRowString);
int targetColumnInt = Convert.ToInt32(targetColumnString);

int deployLeft = targetColumnInt - 1;
int deployRight = targetColumnInt + 1;
int deployUp = targetRowInt + 1;
int deployDown = targetRowInt - 1;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Deploy to:\n({targetRowInt},{deployLeft})\n({targetColumnInt},{deployDown})\n({targetRowInt},{deployRight})\n({deployUp},{targetColumnInt})");
Console.Beep();
