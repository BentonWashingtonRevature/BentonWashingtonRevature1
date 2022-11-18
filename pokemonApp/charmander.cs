namespace pokemonApp;

class Charmander : Pokemon {
    public new int dexNumber = 4;
    public new string name = "Charmander";
    public new string type = "Fire";

    string[] moves = {"Scratch", "Ember"};
    
    public override void Sound(){
        Console.WriteLine("*charmander noises*");
    }

    public override string ToString()
    {
        return $"My name is {name}, pokedex number {dexNumber}. I am a {type} type pokemon.";
    }

}