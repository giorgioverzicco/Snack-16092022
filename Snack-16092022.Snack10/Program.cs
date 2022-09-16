Console.WriteLine("Please, enter an integer number:");
int number = Convert.ToInt32(Console.ReadLine());

var rand = new Random(1337);

for (int i = 0; i < number; i++)
{
    int[] arr = new int[10];
    
    for (int k = 0; k < arr.Length; k++)
    {
        arr[k] = rand.Next(1, 100);
    }
    
    Console.WriteLine($"\nThat's the #{i + 1} array generated:");
    
    for (int k = 0; k < arr.Length; k++)
    {
        Console.WriteLine($"{k + 1}: {arr[k]}");
    }
}