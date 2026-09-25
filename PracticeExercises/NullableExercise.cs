using System.Reflection.Metadata.Ecma335;

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

#region NullableTypesAndOwnClasses
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
//If the person is null, write out "No person given as param" and exit the method
//else, write out the person's name.
//Call the method once with a person object and once with a null.
//DONE


//Think about the difference between having a missing person vs having a person that is missing their age.
//Answer: It would depend on the type of information you want to show to the user(s) and what information is required for applications implementing that data.
//It could be that you are working with sensitive data where the person's age has restricted access.
//You could also be developing a database where the person's age is a required field for a form related to that database.
//Generally speaking it is easier to just check if the Person object is null, instead of examining if each property is null or empty.
#endregion NullableTypesAndOwnClasses
public class Person
{
    public string Name { get; set; } = "";
    public int? Age { get; set; }
    public string? Email { get; set; }

    /// <summary>
    /// Writes the <see cref="Name"/>, <see cref="Age"/>, and <see cref="Email"/> of the Person instance to the console.
    /// </summary>
    public void PrintPersonInfo()
    {
        Email ??= "No Email";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(
            $"Name: {Name}\n" +
            $"Age: {Age?.ToString() ?? "Unknown Age"}\n" +
            $"Email: {Email ??= "No Email"}\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    /// <summary>
    /// Outputs the <see cref="Name"/> of the specified Person to the console.
    /// </summary>
    /// <param name="person">The person whose name to write.</param>
    public void PrintPersonName(Person? person)
    {
        if (person is null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"No person given as param!");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }
        Console.WriteLine($"Name: {person.Name}");
    }
}