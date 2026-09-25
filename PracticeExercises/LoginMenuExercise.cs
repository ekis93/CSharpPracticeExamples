namespace PracticeExercises;

#region  info
//Build a program where you can practice error handling together with menus, loops and methods.

// Write out a menu with options to log in, register a new user, or exit.
//DONE

//When the user picks register new user, prompt them to enter a birth year
#endregion
public class LoginMenuExercise
{
    public void StartMenu()
    {
        DisplayMenu(ReturnMainMenuLayout());
        PromptUser();
    }
    private void DisplayMenu(string menuLayout)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menuLayout);
        Console.ResetColor();
    }
    private string ReturnMainMenuLayout()
    {
        return @$"
 «««««««««« MAIN MENU »»»»»»»»»»
|                               |
|   #1) Log in                  |
|                               |
|   #2) Register new user       |
|                               |
|   #3) Exit                    |
|                               | 
 «««««««««« MAIN MENU »»»»»»»»»»
";
    }
    private void PromptUser()
    {
        char userInput = Console.ReadKey().KeyChar;
        int choiceIndex = Int32.Parse(userInput.ToString())-1;
        string[] choiceArray = ["Log in","Register new user","Exit"];
        string choiceText = $"\nUser picked {choiceArray[choiceIndex]}";
        
        switch (choiceIndex)
        {
            // Log in
            case 0: Console.WriteLine(choiceText);
                break;
            // Register
            case 1: Console.WriteLine(choiceText);
                Console.WriteLine("\nPlease provide a birth year.");
                break;
            // Exit
            case 2: Console.WriteLine(choiceText);
                break;
        }
    }
}