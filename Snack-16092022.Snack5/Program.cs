Console.WriteLine("Please, enter an integer number:");
int number = Convert.ToInt32(Console.ReadLine());

int outputNumber = number % 2 == 0 ? number : number + 1;

Console.WriteLine($"That's the output number: {outputNumber}");