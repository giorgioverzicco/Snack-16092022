const byte MAX_INPUTS = 6;
int[] numbers = new int[MAX_INPUTS];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("\nPlease enter an integer number:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0)
    {
        i--;
        continue;
    }
        
    numbers[i] = number;
}

Console.WriteLine("Your list is:");
for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i + 1}: {numbers[i]}");
}