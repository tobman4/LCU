using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCU.Helper {
    public class GameActivePlayer {

        public GameChampStats championStats { get; set; }
        public float currentGold { get; set; }
        public int level { get; set; }
        public string summonerName { get; set; }

        public override string ToString() {
            return $"{summonerName}({level}) HP: {championStats.currentHealth}";
        }
    }
}
