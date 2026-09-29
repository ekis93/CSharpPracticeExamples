namespace MenuApp;

public class MainMenu
{
    private string MainMenuLayout { get; set; } = "";
    public void Start()
    {
        MenuLayout layout = new MenuLayout();
        MainMenuLayout = layout.ReturnMainMenuLayout();
        DisplayMenu(MainMenuLayout);
        PromptUser();
    }
    
    /// <summary>
    /// Displays the given menu layout.
    /// </summary>
    /// <param name="menuLayout">The menu layout to be shown in the console window.</param>
    private void DisplayMenu(string menuLayout)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menuLayout);
        Console.WriteLine("Please pick an option from the list.");
        Console.ResetColor();
    }
    
    /// <summary>
    /// Registers and validates the user's console input.
    /// </summary>
    private void PromptUser()
    {
        bool keepPrompting = true;
        while (keepPrompting)
        {
            char userInput = Console.ReadKey().KeyChar;
            int? choiceIndex = null;
            string[] choiceArray = ["Log in","Register new user","Exit"];
            
            try
            {
                Console.Clear();
                choiceIndex = Int32.Parse(userInput.ToString())-1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nUser picked {choiceArray[(int)choiceIndex]}");
                Console.ResetColor();
            }
            catch (Exception e)when(e is FormatException or IndexOutOfRangeException) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nINVALID INPUT!");
                Console.ResetColor();
            }
            //DEBUG
            Console.WriteLine("Input: " + userInput);
            //
            switch (choiceIndex)
            {
                
                // Log in
                case 0: Console.Clear(); 
                    Console.WriteLine($"TODO: Implement {choiceArray[0]} menu");
                    goto default;
                    
                // Register
                case 1: Console.Clear(); 
                    Console.WriteLine($"TODO: Implement {choiceArray[1]} menu");
                    //Console.WriteLine("Please provide a birth year.");
                    goto default;
                    
                // Exit
                case 2:
                    Console.WriteLine($"Are you sure you want to exit?\n(y / any other key)");
                    if (Console.ReadKey().KeyChar == 'y') { keepPrompting = false;} 
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\nReturn to Main Menu");
                        goto default;
                    }
                    break;
                default: 
                    DisplayMenu(MainMenuLayout);
                    break;
            }
        }
    }
}