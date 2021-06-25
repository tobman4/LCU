using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCU.Helper {
    public class AllGameData {

        public GameActivePlayer activePlayer { get; set; }
        public GamePlayer[] allPlayers { get; set; }
        public EventObj events { get; set; }
        public GameData gameData { get; set; }
    }
}
