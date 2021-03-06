﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Brannstrom.AdventOfCode.Day6
{
    public class HouseOwner
    {
        public House House { get;  }
        private bool _knowsAncientNordicElvish = false;

        public HouseOwner()
        {
            House = new House();
        }

        public void SetupLights(Instruction instruction)
        {
            for (var x = instruction.FromX; x <= instruction.ToX; x++)
                for (var y = instruction.FromY; y <= instruction.ToY; y++)
                {
                    switch (instruction.Type)
                    {
                        case InstructionType.On:
                            House.Lights[x, y] = _knowsAncientNordicElvish ? House.Lights[x, y] + 1 : 1;
                            break;
                        case InstructionType.Off:
                            House.Lights[x, y] = _knowsAncientNordicElvish ? (House.Lights[x, y] >= 1 ? House.Lights[x, y] - 1 : 0) : 0;
                            break;
                        case InstructionType.Toggle:
                            House.Lights[x, y] = _knowsAncientNordicElvish ? House.Lights[x, y] + 2 : (House.Lights[x, y] == 1 ? 0 : 1);
                            break;
                    }
                }
        }

        public IEnumerable<Instruction> ReadSantasInstructions()
        {
            return ReadInstructionsFromFile().Select(instruction => new Instruction(instruction)).ToList();
        }

        private IEnumerable<string> ReadInstructionsFromFile()
        {
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("Brannstrom.AdventOfCode.Day6.input.txt"))
            using (var reader = new StreamReader(stream))
                while (reader.Peek() >= 0)
                    yield return reader.ReadLine();
        }

        public void LearnAncientElvish()
        {
            _knowsAncientNordicElvish = true;
        }
    }
}
