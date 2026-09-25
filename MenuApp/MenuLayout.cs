namespace MenuApp;

public class MenuLayout
{
    public string ReturnMainMenuLayout()
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