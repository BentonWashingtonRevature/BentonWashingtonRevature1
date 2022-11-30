using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace reflectiondemo
{
    public class PokemonClass
    {
        public PokemonClass(string name, string type, int catchRate, int dexNumber)
        {
            this.Name = name;
            Type = type;
            CatchRate = catchRate;
            DexNumber = dexNumber;

        }
        public string Name { get; set; }
        public string Type { get; set; }
        public int CatchRate { get; set; }
        public int DexNumber { get; set; }


    }
}