using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terramon.Players;
using Terramon.Pokemon.Moves;
using Terraria;
using Terraria.ModLoader;
using static Terramon.Pokemon.ExpGroups;

namespace Terramon.Pokemon.FirstGeneration.Normal.Pidgey
{
    public class Pidgey : ParentPokemon
    {
        public override int EvolveCost => 13;

        public override Type EvolveTo => typeof(Pidgeotto.Pidgeotto);

        public override PokemonType[] PokemonTypes => new[] { PokemonType.Normal, PokemonType.Flying };

        public override ExpGroup ExpGroup => ExpGroup.MediumSlow;public override int MaxHP => 40; public override int PhysicalDamage => 45; public override int PhysicalDefence => 40; public override int SpecialDamage => 35; public override int SpecialDefence => 35; public override int Speed => 56;

        public override void SetDefaults()
        {
            base.SetDefaults();

            
            
        }
    }
}