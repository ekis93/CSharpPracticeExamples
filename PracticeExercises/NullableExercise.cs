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

    public void UserInputAndNullability()
    {
        
    }
}