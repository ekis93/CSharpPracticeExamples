namespace PracticeExercises;

class CSharpOOPExercises
{
    
}
// Create class holding a static method,
public class FryingPan
{
    public static string brand = "Lodge";
    public static string material = "Cast-iron";
    public static int inches = 8;

    public static string GetPanInfo()
    {
        return $"This is a {brand} pan. It is made of {material} " +
               $"and is {inches} inches.";
    }
}

// Exercise OOP - Car
public class Car
{
    //Create field/properties, i.e. maxSpeed, currentSpeed
    public string Model = "BMW";
    public int Mileage = 0;
    public int CurrentSpeedKmh = 0;
    public int TopSpeedKmh = 250;
    
    // Create methods, i.e. GoFaster() and GoSlower()
    public void GoFaster()
    {
        if(CurrentSpeedKmh == 0) Console.WriteLine($"{this.Model} is starting!");
        if (CurrentSpeedKmh < TopSpeedKmh)
        {
            CurrentSpeedKmh++;
        }
        if(CurrentSpeedKmh == TopSpeedKmh) Console.WriteLine($"{this.Model} top speed hit!");
        
    }
    public void GoSlower()
    {
        if (CurrentSpeedKmh > 0)
        {
            CurrentSpeedKmh--;
        }
        if(CurrentSpeedKmh == 0) Console.WriteLine($"{this.Model} is stopping!");
    }
    public void DefineCar(string model, int topSpeed)
    {
        this.Model = model;
        this.TopSpeedKmh = topSpeed;
    }
}

// Create the class CarOwner. TODO: PDF Exercises. Cont at OOP Website Generator
public class CarOwner
{
    public string Name = "John";
    public Car[] ReturnOwnedCars(int ownedCars)
    {
        Car[] cars = new Car[ownedCars];
        for (int i = 0; i < ownedCars; i++)
        {
            cars[i] = new Car();
        }
        return cars;
    }
    
    
}