Console.WriteLine("Please, enter an integer number:");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    IsEven(number) 
    ? $"The number {number} is even" 
    : $"The number {number} is odd");

bool IsEven(int num)
{
    return num % 2 == 0;
}