﻿using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.AdventOfCode.Day20
{
    [TestFixture]
    public class PartOne
    {
        [Test]
        public void Get_First_House_To_Receive_Indicated_Amount_Of_Presents()
        {
            GetFirstHouseToReceiveAmountOfPresents(34000000).Should().Be(786240);
        }

        [Test]
        public void Amount_Of_Presents_Delivered_Should_Be_Ten_Times_Number()
        {
            var elf = new Elf(1337);
            elf.PresentsDelivered.Should().Be(13370);
        }

        [Test]
        public void House_Should_Be_Able_To_Get_Presents()
        {
            var house = new House(5);
            var elf = new Elf(2);
            var secondElf = new Elf(7);
            elf.DeliverPresents(house);
            secondElf.DeliverPresents(house);
            house.Presents.Should().Be(90);
        }

        [Test]
        [TestCase(1, 10)]
        [TestCase(2, 30)]
        [TestCase(3, 40)]
        [TestCase(4, 70)]
        [TestCase(5, 60)]
        [TestCase(6, 120)]
        [TestCase(7, 80)]
        [TestCase(8, 150)]
        [TestCase(9, 130)]
        public void Houses_Should_Get_Correct_Amount_Of_Presents(int houseNumber, int expectedNumberOfPresents)
        {
            var neverendingStreet = new NeverendingStreet();

            neverendingStreet.DeliverPresents();

            neverendingStreet.Houses[houseNumber - 1].Presents.Should().Be(expectedNumberOfPresents);
        }

        [Test]
        [TestCase(20, 2)]
        [TestCase(60, 4)]
        [TestCase(120, 6)]
        [TestCase(130, 8)]
        public void Should_Get_First_House_To_Receive_Indicated_Amount_Of_Presents(int amountOfPresents, int expectedHouseNumber)
        {
            GetFirstHouseToReceiveAmountOfPresents(amountOfPresents).Should().Be(expectedHouseNumber);
        }

        private int GetFirstHouseToReceiveAmountOfPresents(int amountOfPresents)
        {
            var neverendingStreet = new NeverendingStreet();

            neverendingStreet.DeliverPresents();

            return neverendingStreet.GetFirstHouseToReceiveAmountOfPresents(amountOfPresents);
        }
    }
}
