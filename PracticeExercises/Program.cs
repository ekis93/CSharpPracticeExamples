namespace PracticeExercises;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(GenerateHTMLTemplate("klasselassen",["Intro till C#"]));
        Console.ForegroundColor = ConsoleColor.White;
    }
    private static string DefaultName(string klassNamn="klassen")
    {
        return klassNamn;
    }
    private static string[] DefaultMessage(string[] meddelanden = null, int efterfrågadeMeddelanden = 2)
    {
        // Om användaren anger färre meddelanden än vad som efterfrågas i GenerateHTMLTemplate.
        if (meddelanden.Length < efterfrågadeMeddelanden)
        {
            //Kopiera användarens angivna värden i meddelanden till en större array
            string[] largerArray = new String[efterfrågadeMeddelanden];
            meddelanden.CopyTo(largerArray, 0);
            
            // Kolla nu vilka värden som är tomma (null) i den större arrayen.
            for (int i = 0; i < efterfrågadeMeddelanden; i++)
            {
                // Om värdet på index i är tomt (null), tilldela strängen "Mer info tillkommer" 
                largerArray[i] ??= "Mer info tillkommer";
            }
            // Returnera den större arrayen.
            return largerArray;
        }
        return meddelanden;
    }
    private static string GenerateHTMLTemplate(string klassNamn, string[] klassMeddelanden)
    {
        string htmlOutput =
@$"<!DOCTYPE html>
<html>
<body>
    <h1>Välkomna {DefaultName(klassNamn)}!</h1>
    <p><b>Meddelande 1:</b> {DefaultMessage(klassMeddelanden)[0]}.</p>
    <p><b>Meddelande 2:</b> {DefaultMessage(klassMeddelanden)[1]}.</p>
    <main>
        <p>Kurs om C#</p>
        <p>Kurs om Databaser</p>
    </main>
</body>
</html>";
        return htmlOutput;
    }
}
