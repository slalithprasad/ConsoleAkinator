using Microsoft.SemanticKernel;

string openAIModel = "gpt-4o";
string openAIKey = Environment.GetEnvironmentVariable("ConsoleAkinator_OpenAIKey")!;

Kernel sematicKernal = Kernel.CreateBuilder().AddOpenAIChatCompletion(openAIModel, openAIKey).Build();

var conversationHistory = new List<string>();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("====================================");
Console.WriteLine("🎩 Welcome to the Mystical Akinator! 🎩");
Console.WriteLine("I can read your mind... or at least try to!");
Console.WriteLine("Think of something, and I'll guess it by asking yes or no questions.");
Console.WriteLine("Respond with 'y' for Yes, 'n' for No, or 'e' to exit.");
Console.WriteLine("Let's see if I can outsmart you... 😎");
Console.WriteLine("====================================\n");


conversationHistory.Add(@"System: You are Akinator, a guessing game that asks yes or no questions to figure out what the user is thinking. Start by asking, 'Is it a human?' If the answer is 'yes', narrow down by asking about gender, time period (e.g., ancient, medieval, modern), and occupation. If the occupation is an actor, explore if they are from Hollywood, Bollywood, or another film industry. If it's a historical figure, ask about the century they lived in, their role (e.g., leader, inventor, activist), and the region they were influential in. If the answer is 'no', explore other categories systematically: 

- Animals: Ask if it's a pet, wild animal, mythical creature, or extinct species.
- Plants: Ask if it's a tree, flower, herb, or crop.
- Objects: Ask if it's man-made or natural, and then about its use (e.g., technology, household item, tool).
- Places: Narrow down by continent, country, or whether it's a natural landmark or a human-made structure.
- Concepts: Ask if it's an idea, emotion, scientific theory, or philosophical concept.
- Events: Ask if it's historical, fictional, modern, or a recurring event like a holiday.
- Mythical Creatures: Ask about the culture of origin (e.g., Greek, Norse, Japanese) and the type of creature (e.g., dragon, spirit, god).

If you're confident about the answer, make a guess. Possible guesses include humans, animals, objects, places, concepts, events, and mythical creatures. Always prefix your responses with 'Akinator:'. Stick to the English language. Do not generate user responses. Once you believe you've guessed correctly, ask the user if they want to continue playing. If they do, restart the game by asking 'Is it a human?' again.");

while (true)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    string prompt = string.Join("\n", conversationHistory);

    try
    {
        var functionResult = await sematicKernal.InvokePromptAsync(prompt).ConfigureAwait(false);
        string aiResponse = functionResult.GetValue<string>()?.Trim()!;
        Console.WriteLine($"{aiResponse}");

        conversationHistory.Add($"{aiResponse}");
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("An error occurred: " + ex.Message);
        Console.ResetColor();
        continue;
    }

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("You (enter 'y' for yes, 'n' for no, and 'e' for exit): ");
    string? userInput = Console.ReadLine();

    while (string.IsNullOrEmpty(userInput) || (!userInput.Equals("e", StringComparison.OrdinalIgnoreCase) && !userInput.Equals("y", StringComparison.OrdinalIgnoreCase) && !userInput.Equals("n", StringComparison.OrdinalIgnoreCase)))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid input! Please respond with 'y', 'n' or 'e'.");
        Console.ResetColor();
        userInput = Console.ReadLine();
    }

    if (userInput.Equals("e", StringComparison.OrdinalIgnoreCase))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Exiting Akinator... Goodbye!");
        Console.ResetColor();
        break;
    }

    conversationHistory.Add($"You: {userInput}");
}
