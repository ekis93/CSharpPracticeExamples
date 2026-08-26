namespace PracticeExercises;

public class CSharpBasics
{
    //Chapter: Corner stones simplified (Byggstenarna förenklat)
    //These corner stones may sound advanced, but that is not the case.
    //Variables = places where we store data.
    //Types = the type of data we store.
    //Selection and conditions = path choice/questions and outcome
    //Iteration = loops; to do something repeatedly.
    //Arrays = an amount of data stored together.
    
    
    //Chapter: Variables.
    //Variables are places where we may store data/values.
        //Think of them as containers which make room for you to store some sort of information/data.
    //Variables are declared by writing:
        // int someNumber;
        // string myName;
    //Note: We may also write the keyword var, if the type can be derived from the value being assigned to the variable.
        // var someNumber = 15;
        // var myName = "John"
        //Here someNumber gets the type int because it is derived from the whole number 15.
        //myName gets the type string because it is derived from the string value "John"
        
    
    //Chapter: Declare Variables (Deklarera variabler).
    //The type tells us what type of value/information we may store in the variable.
        //Text string, whole number, decimal number, true/false, etc.
    //The name tells us how we may reach the value stored in the variable.
        //In other words, an identifier ("a label") we may use to refer to the variable (and by extension its value).
    
    
    //Chapter: Variables - Terminology (Variabler - Terminologi)
    //Declare the variable = We create a variable
        //int myNum;
        //string name;
    //Assign the variable a value = when we give a value to an already declared variable.
        //myNum = 15;
    //Define a variable = We both create and assign a value to a variable.
        //We declare a variable and assign it a value all in one go.
        //int myNum = 15;
        //string firstName = "John";
    
    
    // Chapter: Variables - Identifier (naming rules) (Variabler: Identifierare (Regler för namngivning))
    //Naming rules:
        //Names may contain letters, numbers, and underscores (_)
        //Names must start with a letter or an underscore.
        //Names should start with a small letter and may not contain spaces.
        //Names are case-sensitive (myVar and myvar are two separate variables).
        //Reserved words (e.g. C# keywords such as 'int' or 'double') may not be used as variable names.
    //The convention in C# is to name variables using camelCase.
        //Small first letter, and every new word starts with a big letter.
        // int someRandomNumber;
        // bool someTrueOrFalseValue;
    
    
    // Chapter: Variables - Types (Variabler: Typer)
    // In C# there are many different types of variables we can use, e.g.:
        // int - Can hold whole numbers (integers) such as 123 or -123.
        // double - Can hold decimal numbers such as 19.99 and -19.99.
        // char - Can hold simple characters such as 'a' or 'B'.
        // string - Can hold whole strings of text, such as "Hello World".
        // bool - Can hold one of two values, either true or false.
    // Types take up different amount of space in memory and may contain different types of data.
    
    
    // Chapter: Types - Decimal numbers (Typer - Decimaltal).
    // double - Holds a decimal number which takes up 64 bits (15 decimal points).
        // Recommended for most calculations.
    // float - 32-bit version of a floating point number (6-7 decimal points).
    // decimal - Can hold enormous floating point numbers and takes up 128 bits.
    
    
    // Chapter: Types - Text (Typer - Text)
    // char - Used for representing a unicode character. It takes up 16 bits.
    // String - Used for connecting several chars in one line.
        // (In C# there are extra benefits for strings. We will cover this in later sections).
    
    
    // Chapter: Types - True/False (Typer - Sant/Falskt)
    // bool - Holds a true or false value.
        // The value is usually written as 'true' or 'false'.
        // These usually requires 8 bits.
    
    
    // Chapter: Types - Others (Typer - Övriga)
    // There are several other types with different memory costs.
    // It may also be a good idea to know the default value of different types.
    // The types will become known to you over time, as you use them.
        // The most important thing is to learn how to search through the documentation,
        // to find where you may learn more about them :D


    // Chapter: Constants (Konstanter)
    // We may use the keyword 'const' for values we do not intend to change.
        // const int monthsInYear = 12;
        // const double pi = 3.14;
    
    
    //Exercise: Variables (Övning: Variabler)
    public void VariableExercise()
    {
        //Declare a variable of type int, and give it the name myAge. Also assign it a value.
        int myAge = 33; 
        //We have just defined the variable (both declaration and assignment in one go).
        
        //State the variable as an input parameter for the WriteLine method.
        Console.WriteLine($"My age is {myAge}");
        
        //Declare a variable of type string.
        string myName;
        
        //Assign it a value.
        myName = "Niklas";
        
        // State both values as concatenated input parameters in the WriteLine method.
        Console.WriteLine("My name is " + myName + " and my age is " + myAge);

        Console.ReadKey();
    }
    
    //Exercise: Whole Numbers (Övning: Heltal)
    public void WholeNumbersExercise()
    {
        // Declare two variables of type int.
        int birthYear;
        int myAge;
        
        // Assign both variables numeric values.
        birthYear = 1993;
        myAge = 33;
        
        // Declare another variable of type int, name it sum.
        int sum;
        
        // Assign sum the value of the first variable (birthyear) added to the second variable (myAge).
        sum = birthYear + myAge;
        
        //Write out the sum to the console
        Console.WriteLine($"The sum of my age and my birth year is {sum}");

        Console.ReadKey();
    }
    
    //Exercise: Double (Övning - Double)
    public void DoubleExercise()
    {
        // Write out the following to the user:
            //1. Measure out 5,5 dl milk.
            //2. Crumble in the yeast.
        // Instead of using the WriteLine method two separate times, google "C# new line".
        // Look for something called "escape character".
        
        var measurement = 5.5; //Just used for showing the type in the console, feel free to disregard.
        
        Console.WriteLine("1. Measure out 5.5 dl milk.\n2. Crumble in the yeast."+
                          "\nMeasurement type " + measurement.GetType());
        Console.ReadKey();
    }
    
    //Exercise: Float (Övning - Float)
    public void FloatExercise()
    {
        // Declare a variable of type float.
        // Give it the name decilitersOfFlour.
        // float decilitersOfFlour;
        
        // Give it a value of 5,5
        // decilitersOfFlour = 5,5;
        
        // The above code will not run for two reasons.
        // The correct code will be put down bellow.
        // Make sure to google "c# float" and see how you assign decimal values to float types.
            // You can also check out the following links:
                // https://www.w3schools.com/cs/cs_data_types.php
                // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/oating-point-numeric-types
        
        // Solution:
        float decilitersOfFlour = 5.5f;
        // When assigning a value to a variable of type float, we must suffix the value with the char 'f'.
        // We must also use a point (.) instead of a comma (,).
        // By default, the compiler automatically recognizes 5.5 as a double.
        // Since we then are trying to assign a value of type double to a variable of type float, we end up with a type error.
        
        
    }
    
    //Exercise: Calculate VAT (Övning - Beräkna moms)
    public void VatExercise()
    {
        //Scenario:
        /*The company you work for is developing a system for
         the grocery chain Mat-Mats. You have been assigned to
         create a function that calculates the pricing, including VAT.
         The VAT rate for the groceries is 6 percent.*/
        
        // The decimal datatype is similar to a float and is used
        //in financial systems. Instead of the suffix 'f', we use 'm'
        //for decimal numbers.
        
        // Write out the instructions to the user:
            // "State the price, not including VAT:"
        Console.WriteLine("State the price, not including VAT:");
        
        // When the user has input the price and pressed enter,
        //the program should calculate the price including VAT.
        decimal vat = 0.06m;
        decimal price = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine($"Calculated price including VAT {price + (price * vat)} ");
        Console.ReadKey();
    }
}
