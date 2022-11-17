namespace pokemonApp;
class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        //Object instantiation
        Pokemon charmander = new Pokemon("charmander");
        Pokemon squirtle = new Pokemon("squirtle");

        //You can use dot notation to access fields and methods available to an object of that class.
        charmander.type = "fire";
        charmander.dexNumber = 4;
        Console.WriteLine(charmander.ToString());
        Console.WriteLine(squirtle.ToString());

        //This is how you call an instance method. It "belongs to" objects of that class.
        //You must instantiate an object of that class to call it.
        //charmander.IsPokemon();

        //This is how you call a Class/static method. It "belongs to" the class. You do not need 
        //to instantiate an object to call it. 
        //Pokemon.Sound();


        //1. Choose Pokemon
        //2. Computer choose pokemon
        //3. 50/50 on who gets to attack first
        //4. when 0

        int bulb = 1;
        int charm = 2;
        int squirt = 3;


        //1. Choose your Pokemon
        Console.WriteLine("Choose your pokemon:\n\tBULBASAUR,\n\tCHARMANDER,\n\tSQUIRTLE");

        //2. Get users input
        string? userInput = Console.ReadLine();
        Console.WriteLine($"You chose - {userInput}!");

        //3. Here we will compare the input to the expected string values
        int isBulbasaur = String.Compare(userInput, 0, "BULBASAUR", 0, 9);
        int isCharmander = String.Compare(userInput, 0, "CHARMANDER", 0, 10);
        int isSquirtle = String.Compare(userInput, 0, "SQUIRTLE", 0, 8);

        int userInt = 0;

        bool userInputValidated = Int32.TryParse(userInput, out userInt);

        if (isBulbasaur != 0 && isCharmander != 0 && isSquirtle!= 0) {
            Console.WriteLine("Answer not valid.");
        } else if (isBulbasaur == 0) {
            userInt = 1;
            string userPoke = "Bulbasaur";
            string type = "Grass";
            int hitPoints = 100;
            int attackPwr = 20;
            Console.WriteLine($"\n\tPokemon: {userPoke}\n\tType: {type}\n\tHP: {hitPoints}\n\tAttack Power: {attackPwr}");
        } else if (isCharmander == 0) {
            userInt = 2;
            string userPoke = "Charmander";
            string type = "Fire";
            int hitPoints = 100;
            int attackPwr = 20;
            Console.WriteLine($"\n\tPokemon: {userPoke}\n\tType: {type}\n\tHP: {hitPoints}\n\tAttack Power: {attackPwr}");
        } else if (isSquirtle == 0) {
            userInt = 3;
            string userPoke = "Squirtle";
            string type = "Water";
            int hitPoints = 100;
            int attackPwr = 20;
            Console.WriteLine($"\n\tPokemon: {userPoke}\n\tType: {type}\n\tHP: {hitPoints}\n\tAttack Power: {attackPwr}");
        } else {
            Console.WriteLine("Invalid answer.");
        }

        Console.WriteLine($"userInt: {userInt}");

//Computer INT
        int compInt = rand.Next(1, 4);
        Console.WriteLine(compInt);

        if (compInt == 1) {
            string cPoke = "Bulbasaur";
            string cType = "Grass";
            int cHitPoints = 100;
            int cAttackPwr = 20;
            Console.WriteLine("Computer chose - BULBASAUR");
            Console.WriteLine($"\n\tPokemon: Bulbasaur\n\tType: Grass\n\tHP: 100\n\tAttack Power: 20");
        } else if (compInt == 2) {
            string cPoke = "Charmander";
            string cType = "Fire";
            int cHitPoints = 100;
            int cAttackPwr = 20;
            Console.WriteLine("Computer chose - CHARMANDER");
            Console.WriteLine($"\n\tPokemon: Charmander\n\tType: Fire\n\tHP: 100\n\tAttack Power: 20");
        } else {
            string cPoke = "Squirtle";
            string cType = "Water";
            int cHitPoints = 100;
            int cAttackPwr = 20;
            Console.WriteLine("Computer chose - SQUIRTLE");
            Console.WriteLine($"\n\tPokemon: Squirtle\n\tType: Water\n\tHP: 100\n\tAttack Power: 20");
        }


        int headsTails = rand.Next(1, 3);
        Console.WriteLine(headsTails);
        if (headsTails == 1) {
            Console.WriteLine("User goes first!");
        } else {
            Console.WriteLine("Computer goes first!");
        }









    }
}

class Pokemon
{
    //Fields

    //Fields are private by default. This field was explicitly declared private.
    private string name;

    //This field is public. It was explicitely declared public. It can be accessed via dot-notation
    //from any object of this class.
    public string type;

    //This field is also private. When no access modifier is explicitly given, the compiler treats the
    //field as private.
    int hitpoints;

    //Auto-property syntax. This creates a backing field, along with the getter and setter. 
    public int dexNumber { get; set; }

    int weight;
    int level;

    //Constructors - Special methods used to instantiate or "create" an instance of a class.
    //You can have as many constructors as you need provided the signatures are different. 
    //This is a common example of method overloading. 
    public Pokemon()
    {

    }

    public Pokemon(string name)
    {
        this.name = name;
    }
    public Pokemon(string pokename, string type, int hp, int dex, int wt, int lvl)
    {
        name = pokename;

        //When the name of a constructor argument and the name of a class field are the same,
        //"this.field" denotes the internal field, versus the argument that gets passed into the 
        //constructor
        this.type = type;
        hitpoints = hp;
        dexNumber = dex;
        weight = wt;
        level = lvl;
    }

    //Methods

    //This method is an instance method. It can be called by an object of class Pokemon using dot-notation.
    public void IsPokemon()
    {
        Console.WriteLine($"My name is {name}. I'm a {type} I am a pokemon.");
    }

    //This method is static. It can be called with dot-notation using the name of the class itself.  
    public static void Sound()
    {
        Console.WriteLine("*pokemon noises*");
    }

    //Overriding
    public override string ToString()
    {
        return $"My name is {name}, number {dexNumber}. I'm a {type} I am a pokemon.";
    }

}
