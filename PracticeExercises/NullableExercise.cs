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

public class NullableTypesAndOwnClasses
{
    
}