using System.Collections.Generic;
using System;

namespace Golf
{

	public class Hole3After {

		private List<Instruction> instructions = new List<Instruction>();

		public void parseCommand(String command) {
			instructions.Add(Instruction.ToPerform(command));
		}

	}

}
