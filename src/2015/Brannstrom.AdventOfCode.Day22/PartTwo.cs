﻿using Brannstrom.AdventOfCode.Day22.Characters;
using Brannstrom.AdventOfCode.Day22.Spells;
using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.AdventOfCode.Day22
{
    [TestFixture]
    public class PartTwo
    {
        private Wizard _player;
        private Character _boss;

        [SetUp]
        public void SetUp()
        {
            _player = new Wizard(50, 0, 0, 500);
            _player.LearnAllSpells();
            _boss = new Character(58, 9, 0, 0);
        }

        [Test]
        public void Should_Find_Least_Amount_Of_Mana_To_Win_Fight_When_Losing_Health_Each_Round()
        {
            var battle = new Battle(_player, _boss);
            battle.EnableHardDifficulty();
            battle.FindLowestManaNeededToWinFight().Should().Be(1309);
        }

        [Test]
        public void Hard_Difficulty_Should_Drain_1_Health_From_Player_Each_Turn()
        {
            var turn = new Turn(_player, _boss, new MagicMissile(), 0, null);
            var duel = new Duel();
            duel.EnableHardDifficulty();
            duel.Fight(turn);
            turn.Player.Hp.Should().Be(_player.Hp - _boss.Damage - 1);
        }
    }
}
