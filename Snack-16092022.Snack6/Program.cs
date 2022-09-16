string[] invitedPeople = { "giorgio", "paolo", "alan", "gianni", "daniele" };

Console.WriteLine("Please, enter your name to check if you are in the list:");
string userInput = Console.ReadLine();

if (!invitedPeople.Contains(userInput.ToLower()))
{
    Console.WriteLine("We're sorry sir, you must leave. Your name is not in our list.");
    return;
}

Console.WriteLine("Feel free to join the party, you're welcome!");