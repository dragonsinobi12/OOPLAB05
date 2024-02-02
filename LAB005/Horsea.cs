using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Horsea : Pokemon
{
    public Horsea()
    {
        name = "Horsea";
        id = 116;
        level = 1;
        HP = 30;
        Att = 40;
        Def = 70;
        SAtt = 70;
        SDef = 25;
        Speed = 60;
        abilities1 = PokemonAbilities.Sniper;
        abilities2 = PokemonAbilities.Damp;
        abilities3 = PokemonAbilities.Swift_Swim;
        type = PokemonType.Water;
        pic = LAB005.Properties.Resources.Horsea;
    }
}
}
