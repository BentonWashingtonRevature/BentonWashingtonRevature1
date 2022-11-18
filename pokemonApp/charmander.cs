namespace pokemonApp;

class Charmander : Pokemon {
    public int dexNumber = 4;
    string name = "Charmander";
    string type = "Fire";

    string[] moves = {"Scratch", "Ember"};
    
    public override void Sound(){
        Console.WriteLine("*charmander noises*");
    }

}