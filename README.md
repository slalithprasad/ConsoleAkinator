# Conssole Akinator 🎩  

A console-based Akinator game built with **C#**, **Microsoft Semantic Kernel**, and **OpenAI** where the AI tries to guess what you're thinking by asking yes or no questions!  

## How It Works

Akinator is a guessing game that tries to figure out what you're thinking by asking a series of yes or no questions. It starts with broad questions and gradually becomes more specific until it makes a guess. Categories include humans, animals, objects, places, concepts, events, and mythical creatures. If Akinator is confident, it makes a guess and asks if you want to play again.

## Prerequisites  
- Download and Install [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download)
- OpenAI API Key: Set as an environment variable named `ConsoleAkinator_OpenAIKey`.  

## Setup
1. Clone the repository:  
    ```bash
    git clone https://github.com/slalithprasad/cosnoleakinator.git
    cd consoleakinator
    ```
2. Install the required NuGet packages:  
    ```bash
    dotnet restore
    ```
3. Set your OpenAI API key as an environment variable:  
    - On Windows:  
      ```powershell
      [Environment]::SetEnvironmentVariable("ConsoleAkinator_OpenAIKey", "your_openai_key", "User")
      ```
    - On MacOS/Linux:  
      ```bash
      export ConsoleAkinator_OpenAIKey="your_openai_key"
      ```

## Running the Game  
```bash
dotnet run
```

## Gameplay  
- 🎩 The AI asks questions to figure out what you're thinking.  
- Respond with:  
  - **'y'** for **Yes**  
  - **'n'** for **No**  
  - **'e'** to **Exit**  
- If the AI guesses correctly, it will ask if you want to play again.  

## Example Gameplay  
```text
====================================
🎩 Welcome to the Mystical Akinator! 🎩
I can read your mind... or at least try to!
Think of something, and I'll guess it by asking yes or no questions.
Respond with 'y' for Yes, 'n' for No, or 'e' to exit.
Let's see if I can outsmart you... 😎
====================================

Akinator: Is it a human?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): n
Akinator: Is it an animal?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is it a pet?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): n
Akinator: Is it a wild animal?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is this wild animal commonly found in forests, deserts, or savannas?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is this wild animal commonly found in forests?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is this wild animal a mammal?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is this mammal known for being a predator?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): n
Akinator: Is this mammal known for living in trees?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is this mammal known for having a long tail?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): n
Akinator: Is this mammal known for being a primate?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): n
Akinator: Is this mammal known for being small in size?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): n
Akinator: Is this mammal known for having distinctive markings or colors?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): n
Akinator: Is this mammal known for having a strong or unique sense, like an enhanced sense of smell or hearing?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is this mammal known for having large ears?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is this mammal known for having a long trunk or specialized nose?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Is it an elephant?
You (enter 'y' for yes, 'n' for no, and 'e' for exit): y
Akinator: Great! I've guessed it correctly. You were thinking of an elephant. Would you like to play again? If so, let's start with a fresh question: Is it a human?
You (enter 'y' for yes, 'n' for no, and 'e' for exit):
``` 

---

Happy guessing! 🎩😎