using System.Collections.Generic;
using System;

namespace Golf
{

	public class Hole2After
	{
		private List<Instruction> instructions = new List<Instruction>();

		public void parseCommand(string command)
		{
			string[] parts = command.Split(null);
			string direction = parts[0];
			int amount = Int32.Parse(parts[1]);

			Instruction instruction = null;
			if (direction == "forward")
				instruction = new MoveInstruction(amount);
			if (direction == "left")
				instruction = new TurnInstruction(amount);
			if (direction == "right")
				instruction = new TurnInstruction(-1 * amount);

			instructions.Add(instruction);
		}

	}

}
