using System.Collections.Generic;
using System;

namespace Golf
{
	public class Hole1Before {

		private List<Instruction> instructions = new List<Instruction>();

		public void parseCommand(string command) {

			string[] parts = command.Split(null);
			string direction = parts[0];
			string amount = parts[1];

			if (direction == "forward") {
				instructions.Add(new MoveInstruction(Int32.Parse(amount)));
			}
			if (direction == "left") {
				instructions.Add(new TurnInstruction(Int32.Parse(amount)));
			}
			if (direction == "right") {
				instructions.Add(new TurnInstruction(-1 * Int32.Parse(amount)));
			}

		}

	}

}
