namespace MenuApp;

public class MainMenu
{
    public void Start()
    {
        MenuLayout layout = new MenuLayout();
        string mainMenuLayout = layout.ReturnMainMenuLayout();
        DisplayMenu(mainMenuLayout);
    }
    
    private void DisplayMenu(string menuLayout)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(menuLayout);
        Console.ResetColor();
    }
}