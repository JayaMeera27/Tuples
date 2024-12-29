// See https://aka.ms/new-console-template for more information

class Sample
{
    public (int id, string name, int age) getDetails()
    {
        return (1, "meera", 26);
    }
}
class Program1
{
    static void Main(string[] args)
    {
        Sample sample = new Sample();
        (int id, string name, int age) person = sample.getDetails();

        //Alternative of above - Deconstruction

        (int personid, string personname, int personage) = sample.getDetails();

        //Discard
        (int personid_1, _, int personage_1) = sample.getDetails();


        Console.WriteLine(person.id);
        Console.WriteLine(person.name);
        Console.WriteLine(person.age);


        Console.WriteLine(personid);
        Console.WriteLine(personname);
        Console.WriteLine(personage);


        Console.WriteLine(personid_1);
        Console.WriteLine(personage_1);

    }
}
