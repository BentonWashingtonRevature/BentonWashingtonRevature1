
namespace delegatedemo;
public class Program
{
    public delegate string Group1sDelegateType1(int x, string y);// this can be represented by a Func delegate. remember this by thinking about how all methods (should) return something. Func delegates have a return type that's not void.
    public delegate void Group1sDelegateType2(Person p, int x, string y);// this can be represented by a Action delegate. Remember this by thinking about this isn't a Func delegate.

    static void Main(string[] args)
    {
        Group1sDelegateType1 benton = MethodClass.AppendString;
        string result = DelegateClass.RegularMethod(benton, 41, "Benton likes to code");
        Console.WriteLine(benton);
        // Console.WriteLine(result);

        
    }
}
