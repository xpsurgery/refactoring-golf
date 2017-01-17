using System.Collections.Generic;
using System;

namespace Golf
{
	public class Hole1After
	{
		private List<Instruction> instructions = new List<Instruction>();

		public void parseCommand(string command)
		{
			string[] parts = command.Split(null);
			string direction = parts[0];
			int amount = Int32.Parse(parts[1]);

			if (direction == "forward")
				instructions.Add(new MoveInstruction(amount));
			if (direction == "left")
				instructions.Add(new TurnInstruction(amount));
			if (direction == "right")
				instructions.Add(new TurnInstruction(-1 * amount));
		}

	}

}
