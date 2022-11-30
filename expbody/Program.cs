namespace expbody;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        int n = 24;
        
        if (Random(n)) {
            Console.WriteLine("Correct Number");
        } else {
            Console.WriteLine("Wrong Number");
        }

    



    }


//1. Expression-bodied Bool Method
    public static bool Random( int number) => number == 41;

//2. Expression-bodied Properties

}
