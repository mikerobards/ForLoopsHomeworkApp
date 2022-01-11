

Console.Write("Please enter a comma-separated list of first names (no spaces!): ");
string data = Console.ReadLine();

List<string> firstNames = data.Split(',').ToList();

for (int i = 0; i < firstNames.Count; i++)
{
    Console.WriteLine($"Hello {firstNames[i]}!");
}

