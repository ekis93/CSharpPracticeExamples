namespace PracticeExercises;

public class NullableExercise
{
    public void UnderstandAndHandleNull()
    {
        string? name = null;
        // if-solution
        // if (name == null)
        // {
        //     name = "";
        // }
        
        //?. solution
        Console.WriteLine(name?.Length);
        
        // ?? solution
        Console.WriteLine(name?.Length ?? 0);
    }
}

public class UserInputAndNullability
{
    //Activate nullable reference types and treat warnings as errors in the project file.
    //DONE
    
    //Create a method which will accept a string and write out its length.
    //DONE
    
    //Let the user write in an arbitrary phrase and send it to the method.
    //DONE
    
    //Handle Console.ReadLine in such a way that it can return null.
    //Ensure that the project can compile without warnings.
    //DONE
    
    //Try two solutions: one with ?. and one with ??
    //?. solution:
    // public void GetStrLength()
    // {
    //     string? userInput = Console.ReadLine();
    //     Console.WriteLine(userInput?.Length);
    // }
    //
    //?? solution.
    //DONE
    public void GetStrLength()
    {
        string userInput = Console.ReadLine() ?? string.Empty;
        Console.WriteLine(userInput.Length);
    }
}

//NullableTypesAndOwnClasses


//Create the following class:
// public class Person
// {
//     public string Name { get; set; } = "";
//     public int? Age { get; set; }
//     public string? Email { get; set; }
// }
//DONE


//Create three people with different names (see program.CS)
//One person is missing an age.
//One person is missing an Email.
//One person has both an age and an Email.
//DONE


//Write out name, age and Email for each person.
//If age is missing, write out "Age unknown";
//If Email is missing, write out "No Email"
//Use ?? where appropriate
//DONE


//IN DEPTH
//Create a method PrintPerson which can receive a Person

public class Person
{
    public string Name { get; set; } = "";
    public int? Age { get; set; }
    public string? Email { get; set; }

    public void GetPersonInfo()
    {
        Email ??= "No Email";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            $"Name: {Name}\n" +
            $"Age: {Age?.ToString() ?? "Unknown Age"}\n" +
            $"Email: {Email ??= "No Email"}\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void PrintPerson()
    {
        
    }
}