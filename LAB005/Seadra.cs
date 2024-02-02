using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Seadra : Pokemon
{
    public Seadra()
    {
        name = "Seadra";
        id = 117;
        level = 10;
        HP = 55;
        Att = 65;
        Def = 95;
        SAtt = 95;
        SDef = 45;
        Speed = 85;
        abilities1 = PokemonAbilities.Sniper;
        abilities2 = PokemonAbilities.Damp;
        abilities3 = PokemonAbilities.Poison_Point;
        type = PokemonType.Water;
        pic = LAB005.Properties.Resources.Seadra;
    }
}
}
