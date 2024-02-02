using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Pikachu : Pokemon
    {
        public Pikachu()
        {
            name = "Pikachu";
            id = 25;
            level = 1;
            HP = 35;
            Att = 55;
            Def = 40;
            SAtt = 50;
            SDef = 50;
            Speed = 90;
            type = PokemonType.Electr;
            abilities1 = PokemonAbilities.LightningRod;
            abilities2 = PokemonAbilities.Static;
            pic = LAB005.Properties.Resources.Pikachu;
        }
    }
}