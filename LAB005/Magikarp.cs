using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Magikarp : Pokemon
{
    public Magikarp()
    {
        name = "Magikarp";
        id = 129;
        level = 1;
        HP = 20;
        Att = 10;
        Def = 55;
        SAtt = 15;
        SDef = 20;
        Speed = 80;
        abilities1 = PokemonAbilities.Swift_Swim;
        abilities2 = PokemonAbilities.Rattled;
        type = PokemonType.Water;
        pic = LAB005.Properties.Resources.Magikarp;
    }
}
}
