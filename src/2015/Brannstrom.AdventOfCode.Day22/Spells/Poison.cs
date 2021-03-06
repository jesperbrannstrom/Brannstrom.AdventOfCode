﻿using Brannstrom.AdventOfCode.Day22.Characters;

namespace Brannstrom.AdventOfCode.Day22.Spells
{
    public class Poison : ISpell
    {
        public void Cast(Character owner, Character target)
        {
            owner.Mana -= Cost;
            target.PoisonTurns = 6;
        }

        public int Cost => 173;
    }
}
