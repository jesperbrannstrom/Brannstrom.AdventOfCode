﻿namespace Brannstrom.AdventOfCode.Day22.Spells
{
    public class Shield : ISpell
    {
        public void Cast(Character owner, Character target)
        {
            owner.Mana -= Cost;
            owner.ShieldTurns = 5;
        }

        public ISpell Copy()
        {
            return new Shield();
        }

        public int Cost => 113;
    }
}
