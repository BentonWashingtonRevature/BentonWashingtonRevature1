namespace pokemonApp;

class Bulbasaur : Pokemon {
    public new int dexNumber = 1;
    public new string name = "Bulbasaur";
    public new string type = "Grass";

    string[] moves = {"Tackle", "Vine Whip"};

    public override void Sound(){
        Console.WriteLine("*bulbasaur noises*");
    }

    public override string ToString()
    {
        return $"My name is {name}, pokedex number {dexNumber}. I am a {type} type pokemon.";
    }
    


}