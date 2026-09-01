namespace PracticeExercises;

public class ExternalExercises
{
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

        for (int i = 0; i < givenNumber; i++)
        {
            numbersArray[i] = i + 1;
        }

        string allNaturalGivenNumbers = string.Join(" ", numbersArray);

        Console.WriteLine($"The first {givenNumber} natural numbers are:\n{allNaturalGivenNumbers}.\n" +
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

        for (int i = 0; i < inputLength; i++)
        {
            numbers[i] = Convert.ToDouble(separatedInput[i]);
        }

        double sum = numbers.Sum();
        double average = sum / inputLength;

        Console.WriteLine($"\nThe sum of the {inputLength} numbers: {sum}" +
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
            Console.WriteLine($"Number is : {numberText} and cube of the {numberText} is :{number * number * number}");
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
            Console.WriteLine($"{userInputNumber} X {i} = {userInputNumber * i}");
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
        for (int i = 1; i <= userInput * 2; i++)
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

    //14. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.
    public void DisplayRightAngleTriangle()
    {
        // The pattern like:
        //    *
        //   * *
        //  * * *
        // * * * *

        string[] triangle = { "*", "* *", "* * *" };
        int stepsToMove = triangle.Length;
        for (int i = 0; i < triangle.Length; i++)
        {
            for (int j = 0; j < stepsToMove; j++)
            {
                triangle[i] = triangle[i].Insert(0, " ");
            }

            Console.WriteLine(triangle[i]);
            stepsToMove--;
        }
    }

    // External Exercises: Arrays
    // See https://www.w3resource.com/csharp-exercises/array/index.php
    // 1. Write a C# program that stores elements in an array and prints them.
    public void PrintArrayElements()
    {
        // Test Data:
        // Input 10 elements in the array:
        // element - 0 : 1
        // element - 1 : 1
        // element - 2 : 2
        // .......
        // Expected Output :
        // Elements in array are: 1 1 2 3 4 5 6 7 8 9 
        int[] myArray = {1,2,3,4,5,6,7,8,9,10};
        Console.WriteLine("Elements in array are: " + string.Join(" ", myArray));
    }
    // 2. Write a C# Sharp program to read n values in an array and display them in reverse order.
    public void PrintArrayReverse()
    {
        // Test Data :
        // Input the number of elements to store in the array :3
        // Input 3 number of elements in the array :
        // element - 0 : 2
        // element - 1 : 5
        // element - 2 : 7
        // Expected Output:
        // The values store into the array are:
        // 2 5 7
        // The values store into the array in reverse are :
        // 7 5 2 
        int [] myArray = {2,5,7,3,9,10};
        Console.WriteLine($"The values store into the array are:\n{string.Join(" ", myArray)}");
        Console.WriteLine($"The values store into the array in reverse are :" +
                          $"\n{string.Join(" ", myArray.Reverse())}\n");
    }
    // 3. Write a program in C# Sharp to find the sum of all array elements.
    public void PrintArraySum()
    {
        // Test Data :
        // Input the number of elements to be stored in the array :3
        // Input 3 elements in the array :
        // element - 0 : 2
        // element - 1 : 5
        // element - 2 : 8
        // Expected Output :
        // Sum of all elements stored in the array is : 15
        int[] myArray = { 2, 4, 8 };
        Console.WriteLine("Sum of all elements stored in the array is : "+myArray.Sum());
        // or
        int sum = 0;
        foreach (int num in myArray)
        {
            sum += num;
        }
        Console.WriteLine("Sum of all elements stored in the array is : "+sum);
    }
    //4. Write a C# Sharp program to copy the elements of one array into another array. 
    public void CopyArrayElements()
    {
        // Test Data :
        // Input the number of elements to be stored in the array :3
        // Input 3 elements in the array :
        // element - 0 : 15
        // element - 1 : 10
        // element - 2 : 12
        // Expected Output:
        // The elements stored in the first array are :
        // 15 10 12
        // The elements copied into the second array are :
        // 15 10 12 

        int[] firstArray = { 2, 5, 6, 8 };
        int[] secondArray = new int[10];
        Console.WriteLine($"he elements stored in the first array are : {string.Join(" ", firstArray)}\n" +
                          $"he elements stored in the second array are : {string.Join(" ", secondArray)}");
        Console.WriteLine("Copying data from array 1 to array 2");
        firstArray.CopyTo(secondArray, 0);
        Console.WriteLine($"he elements stored in the first array are : {string.Join(" ", firstArray)}\n" +
                          $"he elements stored in the second array are : {string.Join(" ", secondArray)}");
        // Note that you can not copy data by doing secondArray = firstArray.
        // This would overwrite the secondArray entirely instead of just copying over the index values.
    }
}