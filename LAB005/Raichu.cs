using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Raichu : Pokemon
    {
        public Raichu()
        {
            name = "Raichu";
            id = 26;
            level = 10;
            HP = 60;
            Att = 90;
            Def = 55;
            SAtt = 90;
            SDef = 80;
            Speed = 110;
            type = PokemonType.Electr;
            abilities1 = PokemonAbilities.LightningRod;
            abilities2 = PokemonAbilities.Static;
            pic = LAB005.Properties.Resources.Raichu;
        }
    }
}