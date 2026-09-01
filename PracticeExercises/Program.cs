namespace PracticeExercises;
using System;

class Program
{
    static void Main(string[] args)
    {
        //ExternalExercises external = new ExternalExercises();
        //external.FindNaturalSumOfGivenNumbers(args[1]);
        SayHi("dood!");
    }

    static void SomeFunction(string indexString, string color)
    {
        int convertedIndex = int.Parse(indexString);
        string[] cars = {"Volvo","Volkswagen","BMW"};
        Console.WriteLine($"\nYou picked a {cars[convertedIndex]} with a {color} color.\n");   
    }

    static void AddTwoNumbers(int numOne, int numTwo){
        int sum = numOne+numTwo;
        Console.WriteLine(sum);
    }
    static void MultiplyTwoNumbers(int numOne, int numTwo){
        int product = numOne*numTwo;
        Console.WriteLine(product);
    }
    static void SayHi(string word){
        string originalWord = "World!";
        Console.WriteLine("Hello "+ originalWord+
            "\nOr something else?");
        string userPhrase = word;
        Console.WriteLine("Hello "+word);
        //
    }

}
