namespace PracticeExercises;

public class Introduction
{
    //*Chapter: Try it yourself (Testa på egen hand).
    // Write a program that asks for the user's name'
    // The user should then be able to answer by writing their name
    // The program should then write out "Hello, NAME"
    // The program should then ask how old the user is
    // The program will then write out the user's age
    public void Greetings()
    {
        Console.WriteLine("Hi user! Please provide me with your name:");
        string? myName = Console.ReadLine();
        Console.WriteLine($"\nHello, {myName}\n");
        Console.WriteLine("\nHow old are you?");
        int myAge = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine($"\nSo you're {myAge} years old? Neat!");
        
        //In-depth (Fördjupning)
        //Write out: "In ten years you'll be " + (myAge + 10) + "years old"
        //Think about why you get an unexpected result.
        // Do a Google search for how you may solve the problem.
        Console.WriteLine("In ten years you'll be " + (myAge + 10) + "years old");
        //Answer: When outputting to the console the result of myAge+10 and the word "years" gets concatenated (linked together).
        //Example: "someText" + "someOtherTex" == someTextsomeOtherText. 
        //To solve this we just need to add a space before the word "years".
        Console.WriteLine((myAge + 10) + " years old");
        Console.ReadKey(); //Needed to keep the console open in some terminals.
        
        //In-depth (Fördjupning).
        //Create and run a project via the terminal.
        //You may use powershell version 5 if you wish (comes with Windows)
    }
}