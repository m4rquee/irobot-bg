namespace BitsGalaxy {
    public class ActionBlock {
        public string actionName;
        public object [] args;

        public ActionBlock (string actionName, object [] args) {
            this.actionName = actionName;
            this.args = args;
        }
    }
}
