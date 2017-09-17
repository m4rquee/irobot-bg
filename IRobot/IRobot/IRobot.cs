using State = System.Collections.Generic.Dictionary<string, object>;

namespace BitsGalaxy {
    public interface IRobot {
        ActionBlock Update(State s);
    }
}
