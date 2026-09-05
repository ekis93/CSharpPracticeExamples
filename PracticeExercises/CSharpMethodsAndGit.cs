using System.Reflection;

namespace PracticeExercises;

//Main class for the PDF exercises
public class CSharpMethodsAndGit
{
    //Exercise - Add two numbers (Addera två tal):
    //Create a method which takes in two numbers, adds these, and writes out the result.
    //Create a method which takes in two numbers, multiplies them, and outputs the result.
    public void AddTwoNumbers(int num1, int num2)
    {
        int sum = num1 + num2;
        Console.WriteLine(sum);
    }
    public void MultiplyTwoNumbers(int num1, int num2)
    {
        int product = num1 * num2;
        Console.WriteLine(product);
    }

    // Exercise - Write out a hello phrase (Skriv ut en hälsningsfras):
    // Create and call a method writing out "Hello World!"
    public void Greetings(string helloReplace = "Hello", string worldReplace = "World")
    {
        //Step 1: Just write out hello world.
        Console.WriteLine($"Hello, World!\n");

        // Step two: Modify the method so that the person calling it is able to send their own argument for
        // what should be written out instead of "World";
        Console.WriteLine($"Modified. Added the worldReplace parameter: \nHello, {worldReplace}!\n");

        // Step three: Modify the method so the caller is also able to choose the greeting phrase.
        Console.WriteLine($"Modified. Added both the worldReplace and heloReplace parameter: " +
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

    // Now we want to be able to send different messages.
    // Allow this by implementing a function which takes in a number of messages.
    // The function then writes them out, one after the other.

    // <!DOCTYPE html>
    // <html>
    // <body>
    // <h1>Välkomna KLASSNAMN-HÄR!</h1>
    // <p><b>Meddelande 1:</b> Klasspecifikt meddelande här.</p>
    // <p><b>Meddelande 2:</b> Klasspecifikt meddelande här.</p>
    // <main>
    // <p>Kurs om C#</p>
    // <p>Kurs om Databaser</p>
    // </main>
    // </body>
    // </html>
    
    //Custom HTML implementation
    private string DefaultName(string klassNamn="klassen")
    {
        return klassNamn;
    }
    private string[] DefaultMessage(string[] meddelanden, int antalMeddelanden)
    {
        // Om användaren anger färre meddelanden än vad som efterfrågas.
        if (meddelanden.Length < antalMeddelanden)
        {
            //Kopiera användarens möjliga angivna värden (som finns i meddelanden arrayen) till en större array
            string[] störreArray = new String[antalMeddelanden];
            meddelanden.CopyTo(störreArray, 0);
            
            for (int i = 0; i < antalMeddelanden; i++)
            {
                // Om värdet på index i är tomt (null), tilldela default värde "Mer info tillkommer" 
                störreArray[i] ??= "Mer info tillkommer";
            }
            // Returnera den större arrayen.
            return störreArray;
        }

        return meddelanden;
    }
    public string GenerateHTMLTemplate(string klassNamn, string[] klassMeddelanden)
    {
        string[] korrMeddelanden = DefaultMessage(klassMeddelanden,3);
        string htmlOutput =
            @$"<!DOCTYPE html>
<html>
<body>
    <h1>Välkomna {DefaultName(klassNamn)}!</h1>
    <p><b>Meddelande 1:</b> {korrMeddelanden[0]}.</p>
    <p><b>Meddelande 2:</b> {korrMeddelanden[1]}.</p>
    <p><b>Meddelande 3:</b> {korrMeddelanden[2]}.</p>
    <main>
        <p>Kurs om C#</p>
        <p>Kurs om Databaser</p>
    </main>
</body>
</html>";
        return htmlOutput;
    }
}