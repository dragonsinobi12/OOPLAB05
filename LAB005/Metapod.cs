using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Metapod : Pokemon
{
    public Metapod()
    {
        name = "Metapod";
        id = 11;
        level = 10;
        HP = 50;
        Att = 20;
        Def = 55;
        SAtt = 25;
        SDef = 25;
        Speed = 30;
        abilities1 = PokemonAbilities.Shed_Skin;
        type = PokemonType.Bug;
        pic = LAB005.Properties.Resources.Metapod;
    }
}
}
