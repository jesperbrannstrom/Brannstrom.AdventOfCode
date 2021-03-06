﻿using System.Collections.Generic;
using System.IO;
using FluentAssertions;
using NUnit.Framework;

namespace Brannstrom.AdventOfCode.Day13
{
    [TestFixture]
    public class PartOne
    {
        [Test]
        public void Should_Calculate_Severity_Of_Moving_Packet_Through_Firewall_In_Example()
        {
            new FireWall(new List<string>()
                {
                    "0: 3",
                    "1: 2",
                    "4: 4",
                    "6: 4"
                })
                .CalculateTotalSeverityWhenMovingThrough()
                .Should()
                .Be(24);
        }

        [Test]
        public void Should_Calculate_Severity_Of_Moving_Packet_Through_Firewall()
        {
            new FireWall(File.ReadAllLines("input.txt"))
                .CalculateTotalSeverityWhenMovingThrough()
                .Should()
                .Be(1316);
        }
    }
}
