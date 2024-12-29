// See https://aka.ms/new-console-template for more information

class Sample
{
    public Tuple<string,int> GetDetails()
    {
        Tuple<string,int> tuple = new Tuple<string,int>("Jaya",26);
        return tuple;
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Tuple<string, int> person = new Tuple<string, int>("Meera", 27);
        Console.WriteLine(person); // ("Meera", 27)
        Console.WriteLine(person.Item1);


        Sample s = new Sample();
        Tuple<string, int> getperson = s.GetDetails();
        Console.WriteLine(getperson.Item1);
        Console.WriteLine(getperson.Item2);

    }
}
