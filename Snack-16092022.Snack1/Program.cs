const byte maxInputs = 2;
List<int> numbers = new();

Console.WriteLine($"Enter {maxInputs} integer numbers:");

for (int i = 0; i < maxInputs; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    numbers.Add(number);
}

Console.Write($"The highest number is: {numbers.Max()}");