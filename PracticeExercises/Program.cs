namespace PracticeExercises;

class Program
{
    static void Main(string[] args)
    {
        //Both age and email
        Person p1 = new Person()
        {
            Name =  "John", 
            Age = 20, 
            Email = "johnDoe@yahoo.com"
        };
        //Missing Email
        Person p2 = new Person()
        {
            Name = "Anne", 
            Age = 30
        };
        //Missing Age
        Person p3 = new Person()
        {
            Name =  "Dave", 
            Email = "DDOSDave@gmail.com"
        };
        //Test person with no info
        Person p4 = new Person() { Name = "Nolan"};
        Person[] personArray = [p1, p2, p3, p4];

        foreach (Person person in personArray)
        {
            person.GetPersonInfo();
        }
    }
}


