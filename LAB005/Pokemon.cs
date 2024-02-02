using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB005
{
    public class Pokemon
    {
        protected int id;
        protected string name;
        protected Image pic;
        protected int level;
        protected PokemonType type;
        protected PokemonAbilities abilities1;
        protected PokemonAbilities abilities2;
        protected PokemonAbilities abilities3;
        protected int HP;
        protected int Att;
        protected int Def;
        protected int SAtt;
        protected int SDef;
        protected int Speed;

        public string Name()
        {
            return name;
        }
        public Image Picture()
        {
            return pic;
        }
    }

    public enum PokemonType
    {
        Grass, Poison, Electr,Bug, Water
    }
    public enum PokemonAbilities
    {
        Overgrow, chlorophyII, Static, LightningRod , Shield_Dust, Run_Away, Shed_Skin, Swift_Swim, Rattled, Sniper, Damp, Poison_Point
    }
}
