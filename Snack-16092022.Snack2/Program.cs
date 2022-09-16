const byte maxInputs = 2;
List<string> words = new();

Console.WriteLine($"Enter {maxInputs} words:");

for (int i = 0; i < maxInputs; i++)
{
    string word = Console.ReadLine() ?? string.Empty;
    words.Add(word);
}

Console.Write($"The longest word is: {words.Max()}");