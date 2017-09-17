using System.Collections.Generic;

namespace BitsGalaxy {
	public class ActionBlock {
		public string actionName;
		public List<object> args;

		public ActionBlock(string actionName, List<object> args) {
			this.actionName = actionName;
			this.args = args;
		}
	}
}
