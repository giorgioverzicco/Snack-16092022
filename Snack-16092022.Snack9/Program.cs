byte MAX_INPUTS = 5;
int[] numbers = new int[MAX_INPUTS];
int index = 0;
int sum = 0;

do
{
    Console.WriteLine("Please, enter an integer number:");
    int number = Convert.ToInt32(Console.ReadLine());
    
    sum += number;

    if (index + 1 == MAX_INPUTS && sum < 50)
    {
        MAX_INPUTS += 1;
        int[] newNumbers = new int[MAX_INPUTS];

        for (int i = 0; i < numbers.Length; i++)
        {
            newNumbers[i] = numbers[i];
        }

        numbers = newNumbers;
    }

    if (sum < 50)
    {
        numbers[index] = number;
    }
    
    index++;
} while (sum < 50);

Console.WriteLine("\nThere's the list of your numbers:");

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"{i+1}: {numbers[i]}");
}