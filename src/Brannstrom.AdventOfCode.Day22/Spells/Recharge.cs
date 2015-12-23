﻿namespace Brannstrom.AdventOfCode.Day22.Spells
{
    public class Recharge : ISpell
    {
        public void Cast(Character owner, Character target)
        {
            owner.Mana -= Cost;
            owner.RechargeTurns = 5;
        }

        public ISpell Copy()
        {
            return new Recharge();
        }

        public int Cost => 229;
    }
}