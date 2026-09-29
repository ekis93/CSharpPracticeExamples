using System.Diagnostics;

namespace MenuApp;

//TODO: Decouple the logic for showing the menu from the MainMenu class.
public class MainMenu
{
    readonly BuildMenuLayout _mainMenuLayout = new BuildMenuLayout("Main Menu");
    readonly BuildMenuLayout _exitMenuLayout = new BuildMenuLayout("Are you sure you want to exit?");
    private bool _keepRunning = true;
    public void Start()
    {
        _mainMenuLayout.AddMenuItem('1',"Login.");
        _mainMenuLayout.AddMenuItem('2',"Register new user.");
        _mainMenuLayout.AddMenuItem('3',"Exit.");
        
        _exitMenuLayout.AddMenuItem('y',"Exit");
        _exitMenuLayout.AddMenuItem('n',"Return");
        
        while (_keepRunning)
        {
            DisplayMenu(_mainMenuLayout);
            PromptUser();
        }
    }
    /// <summary>
    /// Displays the given menu layout.
    /// </summary>
    /// <param name="menuLayout">The menu layout to be shown in the console window.</param>
    private void DisplayMenu(BuildMenuLayout menuLayout)
    {
        Console.WriteLine(menuLayout);
    }
    
    /// <summary>
    /// Registers and validates the user's console input.
    /// </summary>
    private void PromptUser()
    {
        char userInput = Console.ReadKey().KeyChar;
        string[] choiceArray = ["Log in","Register new user","Exit"];
        try
        {
            Console.Clear();
            int? choiceIndex = Int32.Parse(userInput.ToString()) - 1;
            switch (choiceIndex)
            {
                
                // Log in
                case 0:
                    throw new NotImplementedException($"'{choiceArray[0]}' is not implemented yet");
                // Register
                case 1:
                    throw new NotImplementedException($"'{choiceArray[1]}' is not implemented yet");
                // Exit
                case 2:
                    DisplayMenu(_exitMenuLayout);
                    if (Console.ReadKey().KeyChar == 'y')
                    {
                        _keepRunning = false;
                    }
                    break;
            }
        }
        catch (Exception e)when (e is FormatException or IndexOutOfRangeException)
        {
            //DEBUG
            Debug.WriteLine("Input: " + userInput);
            Debug.WriteLine($"\nINVALID INPUT!");
            //
        }
        catch (NotImplementedException e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("That menu item is not implemented yet");
        }
    }
}