namespace LCU {
    public class EOGData {
        public string gameMode{ get; set; }
        public sBlock statsBlock{ get; set; }
    }

    public class sBlock {
        public int gameLengthSeconds{ get; set; }
        public Player[] players{ get; set; }
    }

    public class Player {
        public string summonerName{ get; set; }
        public int health{ get; set; }
        public int ffaStanding{ get; set; }
        public long playerId{ get; set; }
    }
}
