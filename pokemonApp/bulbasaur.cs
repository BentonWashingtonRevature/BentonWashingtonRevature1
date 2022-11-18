namespace pokemonApp;

class Bulbasaur : Pokemon {
    public int dexNumber = 1;
    string name = "Bulbasaur";
    string type = "Grass";

    string[] moves = {"Tackle", "Vine Whip"};

    public override void Sound(){
        Console.WriteLine("*bulbasaur noises*");
    }
    


}