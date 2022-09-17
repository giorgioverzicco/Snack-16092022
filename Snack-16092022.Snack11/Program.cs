Console.WriteLine("Please, enter a string:");
string firstStr = Console.ReadLine();

Console.WriteLine("Please, enter another string:");
string secondStr = Console.ReadLine();

PrintLongest(firstStr, secondStr);

void PrintLongest(string firstString, string secondString)
{
    if (firstString.Length == secondString.Length)
    {
        Console.WriteLine($"They are equal: {firstStr} {secondStr}");
        return;
    }

    string longestString = 
        firstString.Length > secondString.Length 
        ? firstString 
        : secondString;
    
    Console.WriteLine($"That's the longest one: {longestString}");
}