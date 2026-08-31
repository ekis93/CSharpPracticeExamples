namespace PracticeExercises;

using System;
using System.Collections.Generic;

class CSharpBasicsCont()
{
    //Information from the PDF "C# basics, forts."
    private void InformationBlock()
    {
        // Iteration - (Iterering)
        // When we want to do something repetitive we can use a loop.
        // We say that we 'Iterate' och every loop is one 'Iteration'.
        // We can:
        // Iterate/loop until a term evaluates to true.
        // Or iterate over a collection of values.
        // Iteration statements run an instruction, or a block of instructions, multiple times.


    // Iteration Statements
        // while - Does something so long as a term is true.
        // do - Does something so long as a term is true, at least once.
        // for - Does something a specified number of times.
        // foreach - Goes through a collection of items.

        // Jump statements:
        // break - Used for exiting an iteration. Exits the loop
        // continue - used for exiting an iteration and jumping back to the top of the loop
        // Begins the next loop iteration directly instead of waiting for the current iteration to finish.


        // While loop
        // while - Run an instruction or a block of instructions while a give boolean expression is evaluated as true.
        // The expression is evaluated before the loop runs.
        // It therefore can run between 0 - infinite times.
        bool condition = false;
        while (condition)
        {
            // Code block to be executed.
        }


        // While loop - example (exempel)
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }
        //i++ is the same as i = i+1;


        // do-while loop
        // do while - runs, much like a while, but the expression is evaluated after every run.
        // Because the expression is evaluated after, the loop will always run at least once.
        // do-loops runs between 1 - infinite times.

        // do-while loop example (exempel).
        int x = 0;
        do
        {
            Console.WriteLine(x);
            x++;
        } while (x < 5);

        // For loop
        // for loops function like while loops,
        // but here you have to specify a variable which will be used in the loop.
        // initializer - runs once, before entering the loop.
        // Usually you declare and initialize a local variable in this section.
        // Condition - Decide if the next iteration in the loop should be run.
        // Boolean expression. If true, the next iteration is run. If false, the loop exits.
        // Iterator - Defines what will happen after every run of the loop's main block.
        //
        // for (initializer-section; condition-section; iterator section)
        // {
        //      //Code block to be executed
        // }

        // For loop - example.
        for (int a = 0; a < 5; a++)
        {
            Console.WriteLine(a);
        }

        // Break/Continue
        // break - Exits the nearest enclosing iteration statement or switch statement.
        // iteration statement - for, foreach, while, or do loop.
        // continue - starts a new iteration of the nearest enclosing iteration statement.


        // Array: In computer programming we often want to handle large amount of variables/values,
        // to perform different kinds of calculations.
        // Array is an amount of the same typ of data.
        // Saved as a collection.
        // For example a collection of ints (whole numbers).
        // An array in C# is created by writing (observe the brackets!):
        // type[] arrayName;
        string[] cars;
        int[] numbers;

        // Array - Example
        string[] otherCars = { "Volvo", "BMW", "Ford", "Mazda" };
        int[] someNumbers = { 5, 900, 1, 88, 17 };

        // Arrays
        // To retrieve a specific value from an array we can reference its index.
        string[] myArray = new string[9]; // An array with 10 indices, 0-9.
        int index = 3;
        Console.WriteLine(myArray[0]); // first index
        Console.WriteLine(myArray[1]); // second index
        Console.WriteLine(myArray[index]); // fourth index (0,1,2,<3>,4,5).
        // Remember that an index is not a value, but a reference to a place that can hold a value.
        // When we say index 0 we are basically saying "the first place" or "the starting point" in the array.
        // Example:
        string myCar = otherCars[index];
        Console.WriteLine(myCar); // Outputs "Mazda".


        // Iterate arrays - For
        // A common use-case for loops is to traverse arrays.
        // This can be done using a for-loop in the following manner:
        string[] myCars = { "Volvo", "BMW", "Ford", "Mazda" };
        for (int j = 0; j < myCars.Length; j++)
        {
            Console.WriteLine(myCars[j]);
        }
        //test


        // Iterate arrays - Foreach
        string[] myOtherCars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string car in myOtherCars)
        {
            Console.WriteLine(car);
        }
    }

    //Exercise - Loops
    // Write out the numbers 1-10
    // Do this in three different ways (while, do, for)
    public void LoopExercise()
    {
        // While
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
        Console.WriteLine("\nWhile loop done\n");
        
        // Do
        i = 0;
        do
        {
            i++;
            Console.WriteLine(i);
        } 
        while (i < 10);
        Console.WriteLine("\nDo loop done\n");

        // For
        for (i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\nFor loop done\n");
    }
    
    //Exercise - Loops 2
    // Let the user guess a number between 1 and 10.
    // If the number is correct, write out "Congratulations! You guessed right."
    // If the number is incorrect, write out "Wrong! Try again."
    public void UserGuess()
    {
        Console.WriteLine("Guess a number between 1 and 10");
        Random random = new Random();
        int correctNumber = random.Next(1, 10);
        int guessNumber = int.Parse(Console.ReadLine());

        if (guessNumber == correctNumber)
        {
            Console.WriteLine("Congratulations! You guessed right.");
        }
        else
        {
            Console.WriteLine($"Correct number is {correctNumber}.\n Wrong! Try again.");
        }
    }
    
    //Exercise - Read a number fron the user...
    // Write out every number between 1 and the user input,
    // If the number is less than or equals to 0, write an error message.
    public void LoopUserInput()
    {
        Console.WriteLine("Please provide a whole number:");
        int inputNumber = int.Parse(Console.ReadLine());
        if (inputNumber <= 0)
        {
            Console.WriteLine("Please provide a number greater than 0!");
        }
        else
        {
            for (int i = 1; i < inputNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    //Exercise - Create a program that...
    // Lets the user guess a number between 1 and 50.
    // The user has 10 guesses.
    // If the number is correct, write out "Congratulations! You guessed right."
    // Else, write out how many guesses the user has left.
    // After 10 guesses, write out "Game Over :(."
    // Make sure that the program doesn't crash.
    public void UserGuessExtended()
    {
        Console.WriteLine("Guess a number between 1 and 50");
        Random random = new Random();
        int guesses = 5;
        int correctNumber = random.Next(1, 50);
        while (true)
        {
            guesses--;
            int guessedNumber = int.Parse(Console.ReadLine());
            if (guessedNumber == correctNumber)
            {
                Console.WriteLine("Congratulations! You guessed right.");
                break;
            }
            
            if (guesses <= 0)
            {
                Console.WriteLine($"Game Over :(.\n\nCorrect number is {correctNumber}");
                break;
            }
            
            Console.WriteLine($"You guessed wrong! Please try again.");
            Console.WriteLine($"Number of guesses left: {guesses}");
        }
    }
    
    //Exercise - cast
    public void CastExercise()
    {
        //Exercise
        double x = 1234.7;
        int a;

        a = (int)x;
        Console.WriteLine(a);
    }
    
    //Exercise - Fördjupningsövning (TODO)
    public void RomanNumeralsConvert()
    {
        // I:1, V:5, X:10, L:50, C:100, D:500, M:1000
        //example: MMVI = 1000+1000+5+1 = 2006
        string numberStringInput = Console.ReadLine();
        int numberLength = numberStringInput.Length;
        int numberPlace;
        double zeroPlace;
        int charToInt;
        int singleNumberValue;
        string numerals = "";

        for (int i = 0; i < numberLength; i++)
        {
            numberPlace = (numberLength - i);
            zeroPlace = Math.Pow(10, numberPlace - 1);
            charToInt = (int)numberStringInput[i] - (int)'0';
            singleNumberValue = charToInt * (int)zeroPlace;
            //DEBUG
            Console.WriteLine($"The number {numberStringInput[i]} has the place {zeroPlace}.");
            //
            switch (singleNumberValue)
            {
                case >= 1000: //M
                    for (int x = 0; x < singleNumberValue / 1000; x++)
                    {
                        numerals += "M";
                    }

                    break;
                case >= 500: //D
                    numerals += "D";
                    break;
                case >= 100: //C
                    numerals += "C";
                    break;
                case >= 50: //L
                    numerals += "L";
                    break;
                case >= 10: //X
                    numerals += "X";
                    break;
                case >= 5: //V
                    numerals += "V";
                    break;
                case >= 1: //I
                    numerals += "I";
                    break;
            }
        }

        Console.WriteLine(numerals);
    }
    
    // External Exercises: For Loop
    // See https://www.w3resource.com/csharp-exercises/for-loop/index.php#google_vignette
    //1. Write a program in C# to display the first 10 natural numbers.
    public void DisplayNumbersArray()
    {
        string numbersArray = "";
        for (int i = 1; i <= 10; i++)
        {
            numbersArray += i + " ";
        }
        Console.WriteLine(numbersArray.Trim());
        
    }
    //2. Write a C# program to find the sum out of the first 10 natural numbers.
    public void FindNaturalSum()
    {
        // Expected output:
        // The first 10 natural number is :
        // 1 2 3 4 5 6 7 8 9 10
        // The Sum is : 55
        int[] numbersArray = new int[10];
        int sum = 0;
        for (int i = 0; i < 10; i++)
        {
            numbersArray[i] += i + 1;
        }
        sum = numbersArray.Sum();
        Console.Write($"The first 10 natural numbers are: {string.Join(" ", numbersArray)}." +
                      $"\nThe sum is: {sum}");
    }
    //3. Write a C# program that displays the sum of n natural numbers.
    public void FindNaturalSumOfGivenNumbers(string n)
    {
        // Test Data : 7
        // Expected Output :
        // The first 7 natural number is :
        // 1 2 3 4 5 6 7
        // The Sum of Natural Number upto 7 terms : 28 
        int givenNumber = Convert.ToInt32(n);
        int[] numbersArray = new int[givenNumber]; 
        
        for (int i=0; i < givenNumber; i++)
        {
            numbersArray[i] += i + 1;
        }
        
        string allNaturalGivenNumbers = string.Join(" ", numbersArray);
        
        Console.WriteLine($"The first {givenNumber} natural numbers are:\n{allNaturalGivenNumbers}.\n"+
            $"The sum of all natural numbers up to {givenNumber} terms: {numbersArray.Sum()}");
    }
    //4. Write a C# program to read 10 numbers and find their average and sum.
    public void FindAverageAndSum()
    {
        //their average and sum.
        //Test Data :
        //Input the 10 numbers :
        //Number-1 :2
        //...
        //Number-10 :2
        //Expected Output :
        //The sum of 10 no is : 51
        // The Average is : 5.100000

        Console.WriteLine("Please provide n numbers separated by space:");
        string[] separatedInput = Console.ReadLine().Split(' ');
        int inputLength = separatedInput.Length;
        double[] numbers = new double[inputLength];
        
        for(int i = 0; i<inputLength; i++)
        {
            numbers[i] = Convert.ToDouble(separatedInput[i]);
        }

        double sum = numbers.Sum();
        double average = sum/inputLength;

        Console.WriteLine($"\nThe sum of the {inputLength} numbers: {sum}"+
            $"\nThe average: {average}");   
    }
    //5. Write a C# program to display the cube of an integer up to a given number.
    public void DisplayIntCubed()
    {
        // Mathematical explanation:
        // See Arithmetic and Algebra,
        // Cube of a number n: The number n to the third power.
        // Example 2³ or 2*2*2
      
        
        //Test Data:
        // Input number of terms: 5.
        //Expected output:
        // Number is : 1 and cube of the 1 is :1
        // Number is : 2 and cube of the 2 is :8
        // Number is : 3 and cube of the 3 is :27
        // Number is : 4 and cube of the 4 is :64
        // Number is : 5 and cube of the 5 is :125
        Console.WriteLine("Please provide a couple of numbers, separated by whitespace.");
        string[] userInput = Console.ReadLine().Split(' ');
        int number = 0;
        foreach (string numberText in userInput)
        {
            number = int.Parse(numberText);
            Console.WriteLine($"Number is : {numberText} and cube of the {numberText} is :{number*number*number}");
        }
    }
    //6. Write a program in C# to display the multiplication table of a given int.
    public void DisplayMultiplicationTable()
    {
        //Test Data:
        // Test Data :
        // Input the number (Table to be calculated) : 15
        // Expected Output :
        // 15 X 1 = 15
        //     ...
        // ...
        // 15 X 10 = 150
        Console.WriteLine("Input the number (Table to be calculated):");
        int userInputNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{userInputNumber} X {i} = {userInputNumber*i}");
        }
    }
    //7. Write a program in C# to display the multiplication table vertically.
    public void DisplayVerticalMultiTable()
    {
        // from 1 to n.
        // Test Data :
        // Input upto the table number starting from 1 : 8
        // Expected Output :
        // Multiplication table from 1 to 8
        // 1x1 = 1, 2x1 = 2, 3x1 = 3, 4x1 = 4, 5x1 = 5, 6x1 = 6, 7x1 = 7, 8x1 = 8
        //     ...
        // 1x10 = 10, 2x10 = 20, 3x10 = 30, 4x10 = 40, 5x10 = 50, 6x10 = 60, 7x10 = 70, 8x10 = 80 
        
        //Notes. For every number the user gives, display each section of the table on its own line.
        // If the user enters 1 2 3, the table should look as follows.
        // 1x1=1, 2x1=1, 3x1=1
        // 1x2=2, 2z2=4, 3x2=6
        // etc.
        Console.WriteLine("Input n numbers to the console (separated by whitespace):");
        string[] userInput = Console.ReadLine().Split(' ');
        string tableOutput = "";
        int number = 0;
        foreach (string numberText in userInput)
        {
            number = int.Parse(numberText);
            for (int i = 1; i <= 10; i++)
            {
                tableOutput += $"{number}X{i} = {number * i}, ";
            }
            Console.WriteLine(tableOutput.TrimEnd(", "));
            tableOutput = "";
        }
    }
    //8. Write a C# program to display the n terms of odd natural numbers and their sums.
    public void DisplayNatOddAndSum()
    {
        // Test Data
        // Input number of terms : 10
        // Expected Output :
        // The odd numbers are :1 3 5 7 9 11 13 15 17 19
        // The Sum of odd Natural Number upto 10 terms : 100 
        Console.WriteLine("Input number of terms to the console (in the form of a single int):");
        int userInput = int.Parse(Console.ReadLine());
        string consoleOutput = "";
        int sum = 0;
        
        /*Explanation for userInput*2
        Every 2 consecutive numbers contain exactly 1 odd number.
        To find N odd numbers, first you must search through the range of 2N total numbers.*/
        for (int i = 1; i <= userInput*2; i++)
        {
            if (i % 2 != 0)
            {
                consoleOutput += $"{i} ";
                sum += i;
            }
        }
        Console.WriteLine($"The odd numbers are :{consoleOutput}");
        Console.WriteLine($"The Sum of odd Natural Number upto 10 terms : {sum}");
    }
}