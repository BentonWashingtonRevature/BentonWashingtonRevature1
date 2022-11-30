using System.Text.Json;

namespace pokemonApp;
class Program
{
    static void Main(string[] args)
    {

        var bulbito = new Bulbasaur {
            Classification = "Grass Pokemon",
            Region = "Kanto"
        
        };
// 1. Serialize
        // string jsonString = JsonSerializer.Serialize(bulbito);
        // Console.WriteLine(jsonString);
// 2. File
        string fileName = "Bulbasaur.json";
        string jsonString = JsonSerializer.Serialize(bulbito);
        File.WriteAllText(fileName, jsonString);

        Console.WriteLine(File.ReadAllText(fileName));
// 3. Deserialize
Bulbasaur? bulbito2 =
    JsonSerializer.Deserialize<Bulbasaur>(jsonString);

    Console.WriteLine($"Classification: {bulbito2?.Classification}");
    Console.WriteLine($"Region: {bulbito2?.Region}");




        Random rand = new Random();
        //Object instantiation
        Charmander charchar = new Charmander();
        Bulbasaur bulba = new Bulbasaur();
        Squirtle turtlebuddy = new Squirtle();
        Console.WriteLine(charchar);
        Console.WriteLine(bulba);
        Console.WriteLine(turtlebuddy);

        // Pokemon charmander = new Pokemon("charmander");
        // Pokemon squirtle = new Pokemon("squirtle");

        //You can use dot notation to access fields and methods available to an object of that class.
        // charmander.type = "fire";
        // charmander.dexNumber = 4;
        // Console.WriteLine(charmander.ToString());
        // Console.WriteLine(squirtle.ToString());

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

