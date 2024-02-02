using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Caterpie : Pokemon
{
    public Caterpie()
    {
        name = "Caterpie";
        id = 10;
        level = 1;
        HP = 45;
        Att = 30;
        Def = 35;
        SAtt = 20;
        SDef = 20;
        Speed = 45;
        type = PokemonType.Bug;
        abilities1 = PokemonAbilities.Shield_Dust;
        abilities2 = PokemonAbilities.Run_Away;
        pic = LAB005.Properties.Resources.Caterpie1;
    }
}
}
