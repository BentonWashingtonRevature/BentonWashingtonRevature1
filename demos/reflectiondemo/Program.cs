using System.Reflection;

namespace reflectiondemo;
class Program
{
    public int BentonsMomsAge { get; set; } = 53;
    public string BentonsMomsName { get; set; } = "Eulonda";
    public static int zipcode = 12241;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        PokemonClass poke = new PokemonClass("Treecko", "Grass", 45, 252);

        //Type class in the "medium of exchange" for Reflection.
        Program p = new Program();
        Type programType = typeof(Program);
        // Console.WriteLine(programType);
        // Type type2 = typeof(PokemonClass);
        // Console.WriteLine(type2);

        MemberInfo[] mbrArr = programType.GetMembers();
        foreach(var x in mbrArr){
            Console.WriteLine($"{x.Name} - {x.DeclaringType}");
            if (x.Name.Equals("get_BentonsMomsAge"))
            {
                MethodInfo mi = (MethodInfo)x;
                var x1 = mi.GetMethodBody();
                Console.WriteLine(x1.MaxStackSize);
            }
        }

        var assembly = programType.Assembly;
        Console.WriteLine($"{assembly.GetName().FullName}");

        var fields = programType.GetFields();
        foreach(FieldInfo x in fields)
        {
            var xx = x.Attributes;
            x.SetValue(null, 76011);
            Console.WriteLine($"{xx.ToString()}'s value is now {x.GetValue(null)}");
        }
        // FieldInfo fi = programType.GetField("zipcode", BindingFlags.Instance | BindingFlags.Static!);
        // Console.WriteLine($"Name - {fi.Name}, value - {fi.GetValue(p)}, fieldhandle -..., ifFamilt,etc - {fi.IsFamilyO")

    }
}
