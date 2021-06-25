namespace LCU.Helper {
    public class GameEvent {
        public int EventID{ get; set; }
        public string EventName{ get; set; }
        public float EventTime{ get; set; }

        public string KillerName{ get; set; }
        public string VictimName{ get; set; }
    }
}
