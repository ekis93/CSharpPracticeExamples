using System.Reflection;

namespace PracticeExercises;

public class CSharpMethodsAndGit
{
    //Exercise - Add two numbers (Addera två tal):
    //Create a method which takes in two numbers, adds these, and writes out the result.
    public void AddTwoNumbers(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine(sum);
    }
    //Create a method which takes in two numbers, multiplies them, and outputs the result.
    public void MultiplyTwoNumbers(int num1, int num2)
    {
        int product = num1 * num2;
        Console.WriteLine(product);
    }
    
    // Exercise - Write out a hello phrase (Skriv ut en hälsningsfras):
    // Create and call a method writing out "Hello World!"
    public void Greetings(string helloReplace ="Hello", string worldReplace="World")
    {
        //Step 1: Just write out hello world.
        Console.WriteLine($"Hello, World!\n");
        
        // Step two: Modify the method so that the person calling it is able to send their own argument for
        // what should be written out instead of "World";
        Console.WriteLine($"Modified. Added the worldReplace parameter: \nHello, {worldReplace}!\n");
        
        // Step three: Modify the method so the caller is also able to choose the greeting phrase.
        Console.WriteLine($"Modified. Added both the worldReplace and heloReplace parameter: "+
                          $"\n{helloReplace}, {worldReplace}!\n");
        
        // How to provide separate arguments for parameters:
        // When we call the function we can decide if we want to provide both parameters, or just one, with arguments.
        // To provide a single argument, specify the parameter by name, followed by a colon, followed by the argument:
        // Example 1: Greetings(helloReplace:"Heya");
        // Example 2: Greetings(worldReplace:"Dude");
        // Or you can simply provide both arguments directly, separated by comma, in the order of declaration in the method:
        // Example: Greetings("Heya","Dude");
    }
    
    //Exercise - Websitegenerator (Hemsidegenerator):
    // You have been assigned to standardize the creation of an HTML generator in C#.
   
    
    // Create methods to preform chosen parts of the creation of the following code:
    // <!DOCTYPE html>
    // <html>
    // <body>
    // <h1>Välkomna!</h1>
    // <main>
    // <p>Kurs om C#</p>
    // <p>Kurs om Databaser</p>
    // </main>
    // </body>
    // </html>
    
    
    //Use parameters and return types to allow the h1 tag to write welcome to a given class.
    // There should also be a specific message to the class sent in as a parameter.
    
    
    // <!DOCTYPE html>
    // <html>
    // <body>
    // <h1>Välkomna KLASSNAMN-HÄR!</h1>
    // <p><b>Meddelande:</b> Klasspecifikt meddelande här.</p>
    // <main>
    // <p>Kurs om C#</p>
    // <p>Kurs om Databaser</p>
    // </main>
    // </body>
    // </html>
    
    public void HTMLStructure(string welcomeMessage="Välkomna!", string courseOne="C#", string courseTwo="Databaser")
    {
        Console.WriteLine("<!DOCTYPE html>\n"+
                          "<html>\n"+
                          "<body>\n"+
                          $"<h1>{welcomeMessage}<h1/>\n"+
                          "<main>\n"+
                          $"<p>Kurs om {courseOne}</p>\n"+
                          $"<p>{courseTwo}</p>\n"+
                          "</main>\n"+
                          "</body>\n"+
                          "</html>");
    }
}