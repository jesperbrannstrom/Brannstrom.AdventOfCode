﻿using System.Collections.Generic;
using System.Linq;

namespace Brannstrom.AdventOfCode.Day2
{
    public class PresentBox
    {
        public int Length { get; }
        public int Width { get; }
        public int Height { get; }

        public PresentBox(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int WrappingPaperSize => SurfaceArea + SmallestSide;

        private int SurfaceArea => 2 * Length * Width + 2 * Width * Height + 2 * Height * Length;

        private int SmallestSide => new List<int>() { Length * Width, Width * Height, Height * Length }.Min();

        public int RibbonLength => ShortestDistanceAroundSides + Volume;

        private int ShortestDistanceAroundSides => new List<int>() { 2*Length + 2*Width, 2*Width + 2*Height, 2*Height + 2*Length }.Min();

        private int Volume => Length * Width * Height;
    }
}
