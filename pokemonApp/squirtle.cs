namespace pokemonApp;

class Squirtle : Pokemon {
    public int dexNumber = 7;
    string name = "Squirtle";
    string type = "Water";

    string[] moves = {"Tackle", "Bubble"};


        public override void Sound(){
        Console.WriteLine("*squirtle noises*");
    }

    public override string ToString()
    {
        return $"My name is {name}, pokedex number {dexNumber}. I am a {type} type pokemon.";
    }


}