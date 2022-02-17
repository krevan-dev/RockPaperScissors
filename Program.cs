//run program, take input, math.random a selection, compare the outcome to the input, match type = draw, define non-matches...
Console.ForegroundColor = ConsoleColor.Green;
Console.Clear();
Console.WriteLine("Let's play Rock, Paper, Scissors!");
Console.WriteLine();
Console.WriteLine("Please make your selection...");
var weapon = Console.ReadLine();
Console.WriteLine($"You have selected {weapon}");