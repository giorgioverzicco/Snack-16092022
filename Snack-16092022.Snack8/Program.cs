var rand = new Random(1337);
int[] numbers = new int[rand.Next(10, 20)];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 1000);
}

int sum = numbers
    .Where(x => x % 2 != 0)
    .Sum();
    
Console.WriteLine($"The sum of all odd numbers is: {sum}");